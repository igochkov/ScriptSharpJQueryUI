// Generator.cs
// jQueryUIGenerator
//
// Copyright 2012 Ivaylo Gochkov
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using ScriptSharp.Tools.jQueryUIGenerator.Model;

namespace ScriptSharp.Tools.jQueryUIGenerator {
    /// <summary>
    /// Script# jQueryUI API generator
    /// </summary>
    public partial class Generator {
        private string DestinationPath;
        private TextWriter Messages;

        private string[] excludeJQueryMethods = new string[] { "show", "hide", "toarray" };
        private string[] abstractObjects = new string[] { "widget", "effect", "ui" };

        /// <summary>
        /// Creates a generator of ScriptSharp jQueryUI library.
        /// </summary>
        /// <param name="destinationPath">Location of the generated files.</param>
        /// <param name="messageStream">A message stream.</param>
        public Generator(string destinationPath, TextWriter messageStream = null) {
            Debug.Assert(!string.IsNullOrEmpty(destinationPath), "Destination path is not specified.");

            DestinationPath = destinationPath;
            Messages = messageStream ?? TextWriter.Null;
        }

        /// <summary>
        /// Generates SriptSharp files
        /// </summary>
        /// <param name="entries">List of jQueryUI entries.</param>
        public void Render(IList<Entry> entries) {
            if (entries == null) {
                return;
            }

            DirectoryInfo destination = new DirectoryInfo(DestinationPath);
            if (destination.Exists) {
                destination.Delete(true);
            }

            foreach (Entry entry in entries) {
                Messages.WriteLine("Generating " + Path.Combine(DestinationPath, Utils.PascalCase(entry.Name)));

                Entry baseEntry = null;
                if (!string.IsNullOrEmpty(entry.Type)) {
                    // find the base entry
                    baseEntry = entries.SingleOrDefault(e => e.Name.ToLower() == entry.Type.ToLower());
                }

                RenderEntry(entry, baseEntry);
            }

            RenderEventHandler();
            RenderJQueryUI();
            RenderWidgetType(entries);
        }

        private void RenderEntry(Entry entry, Entry baseEntry = null) {
            if (entry == null) {
                return;
            }

            RenderObject(entry);
            RenderOptions(entry);
            RenderEvents(entry);

            RenderOptionEnum(entry, baseEntry);
            RenderEventsEnum(entry, baseEntry);
            RenderMethodEnum(entry, baseEntry);
        }

        private void RenderObject(Entry entry) {
            string className = Utils.PascalCase(entry.Name) + @"Object";

            string content =
@"using System;
using System.Runtime.CompilerServices;

namespace {8} {{

    /// <summary>
    /// {1}
    /// </summary>
    /// <remarks>
    /// {2}
    /// </remarks>
    [Imported]
    [IgnoreNamespace]{7}
    public "
+ (abstractObjects.Contains(entry.Name.ToLower()) ? "abstract" : "sealed") + @" class {0} : "
+ (string.IsNullOrEmpty(entry.Type) ? "jQuery" : Utils.PascalCase(entry.Type)) + @"Object {{

        "
+ (abstractObjects.Contains(entry.Name.ToLower()) ? "protected" : "private") + @" {0}() {{
        }}{3}{4}{5}{6}
    }}
}}";

            string overload1 =
@"

        [ScriptName(""{0}"")]
        public {2}{1}Object {1}() {{
            return null;
        }}";

            string overload2 =
@"

        [ScriptName(""{0}"")]
        public {1}Object {1}({1}Options options) {{
            return null;
        }}";

            string overload3 =
@"

        [ScriptName(""{0}"")]
        public object {1}({1}Method method, params object[] options) {{
            return null;
        }}";

            string overload4 =
            @"

        [IntrinsicProperty]
        public static object Prototype {{
            get {{
                return null;
            }}
        }}

        [IntrinsicProperty]
        public jQueryObject Element {{
            get {{
                return null;
            }}
        }}

        [IntrinsicProperty]
        public object Options {{
            get {{
                return null;
            }}
        }}

        [IntrinsicProperty]
        [ScriptName(""_setOption"")]
        public Function SetOption {{
            get {{
                return null;
            }}
        }}

        [IntrinsicProperty]
        [ScriptName(""_setOptions"")]
        public Function SetOptions {{
            get {{
                return null;
            }}
        }}

";

            StringBuilder methodsContent = new StringBuilder();

            foreach (var method in entry.Methods
                // exclude the jQuery methods as they will be inherit
                                        .Where(m => entry.Name.ToLower() == "widget" || !excludeJQueryMethods.Contains(m.Name.ToLower()))
                                        .OrderBy(m => m.Name)) {

                // TODO: temporal solution for SetOption & SetOptions. Cannot have property and Method with the same name.
                if (method.Name.ToLower() == "_setoption" || method.Name.ToLower() == "_setoptions") {
                    continue;
                }

                methodsContent.AppendLine();
                methodsContent.AppendLine();
                methodsContent.AppendLine("        /// <summary>");
                methodsContent.AppendLine("        /// " + Utils.FormatXmlComment(method.Description.Replace("<entryname />", entry.Name)));
                methodsContent.AppendLine("        /// </summary>");
                if (Utils.PascalCase(method.Name).ToLower() != method.Name.ToLower()) {
                    methodsContent.AppendLine("        [ScriptName(\"" + method.Name + "\")]");
                }

                methodsContent.Append("        public " + (string.IsNullOrEmpty(method.ReturnType) ? "void" : Utils.MapDataType(method.ReturnType)) + " " + Utils.PascalCase(method.Name) + "(");
                List<string> args = new List<string>();
                foreach (Argument arg in method.Arguments) {
                    args.Add(Utils.MapDataType(arg.Type) + " " + (arg.Name == "event" ? "@event" : arg.Name));
                }
                methodsContent.AppendLine(string.Join(", ", args) + ") {");
                if (!string.IsNullOrEmpty(method.ReturnType)) {
                    methodsContent.AppendLine("                return " + Utils.GetDefaultValue(method.ReturnType) + ";");
                }
                methodsContent.AppendLine("        }");
            }

            string formatedContent = string.Empty;

            if (entry.Name.ToLower() == "widget") {
                formatedContent
                        = string.Format(content
                                        , className
                                        , Utils.FormatXmlComment(entry.Description.Replace("<entryname />", entry.Name))
                                        , Utils.FormatXmlComment(entry.LongDescription.Replace("<entryname />", entry.Name))
                                        , string.Empty
                                        , string.Empty
                                        , string.Empty
                                        , string.Format(overload4, entry.Name, Utils.PascalCase(entry.Name)) + methodsContent.ToString()
                                        , @"
    [ScriptName(""$.Widget"")]"
                                        , Utils.GetNamespace(entry));
            } else {
                formatedContent
                    = string.Format(content
                                    , className
                                    , Utils.FormatXmlComment(entry.Description.Replace("<entryname />", entry.Name))
                                    , Utils.FormatXmlComment(entry.LongDescription.Replace("<entryname />", entry.Name))
                                    , string.Format(overload1, entry.Name, Utils.PascalCase(entry.Name), (entry.Name.ToLower() == "position" || entry.Name.ToLower() == "size") ? "new " : string.Empty)
                                    , (entry.Options.Count > 0) ? string.Format(overload2, entry.Name, Utils.PascalCase(entry.Name)) : string.Empty
                                    , (entry.Methods.Where(m => !excludeJQueryMethods.Contains(m.Name.ToLower())).Count() > 0) ? string.Format(overload3, entry.Name, Utils.PascalCase(entry.Name)) : string.Empty
                                    , methodsContent.ToString()
                                    , string.Empty
                                    , Utils.GetNamespace(entry));
            }

            string name = Utils.PascalCase(entry.Name);
            if ((name == "jQueryUI") || (name == "Position")) {
                name = "";
            }
            string category = Utils.PascalCase(entry.Category);
            if ((category == "Widgets") && (name == "Widget")) {
                category = "";
                name = "";
            }
            Utils.CreateFile(Path.Combine(DestinationPath, category, name), className, formatedContent);
        }

        private void RenderOptions(Entry entry) {
            if (entry.Events.Count == 0 && entry.Options.Count == 0) {
                return;
            }

            string className = Utils.PascalCase(entry.Name) + @"Options";

            string content =
@"using System;
using System.Runtime.CompilerServices;

namespace {4} {{

    /// <summary>
    /// Options used to initialize or customize {5}.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName(""Object"")]
    public {3} class {0} {{

        public {0}() {{
        }}

        public {0}(params object[] nameValuePairs) {{
        }}
{1}{2}    }}
}}";
            StringBuilder eventsContent = new StringBuilder();

            foreach (Event @event in entry.Events.AsQueryable().OrderBy(e => e.Name)) {
                if (!@event.Type.StartsWith("function")) {
                    if (!string.IsNullOrEmpty(@event.Description)) {
                        eventsContent.Append(
@"
        /// <summary>
        /// " + Utils.FormatXmlComment(@event.Description.Replace("<entryname />", entry.Name)) + @"
        /// </summary>");
                    }

                    string eventType;

                    if (string.IsNullOrEmpty(@event.Type)) {
                        eventType = "jQueryEventHandler";
                    } else {
                        if (@event.Arguments.All(a => a.Properties.Count == 0)) {
                            eventType = "jQueryUIEventHandler<jQueryObject>";
                        } else {
                            eventType = "jQueryUIEventHandler<" + Utils.PascalCase(@event.Type.Replace(@event.Name.ToLower(), Utils.PascalCase(@event.Name))) + "Event" + ">";
                        }

                    }

                    eventsContent.AppendLine(
@"
        [IntrinsicProperty]
        public " + eventType + " " + Utils.PascalCase(@event.Name) + " {" +
@"
             get {
                return null;
             }
             set {
             }
        }");
                }
            }

            StringBuilder optionsContent = new StringBuilder();

            foreach (var option in entry.Options.AsQueryable()
                                           .OrderBy(o => o.Name)
                                           .GroupBy(o => o.Name)) {
                if (!string.IsNullOrEmpty(option.Min(o => o.Description))) {
                    optionsContent.Append(
@"
        /// <summary>
        /// " + Utils.FormatXmlComment(option.Min(o => o.Description).Replace("<entryname />", entry.Name)) + @"
        /// </summary>");
                }

                optionsContent.AppendLine(@"
        [IntrinsicProperty]
        public " + Utils.MapDataType(option.Min(o => o.Type)) + @" " + Utils.PascalCase(option.Key) + @" {" +
@"
            get {
                return " + Utils.GetDefaultValue(option.Min(o => o.Type)) + @";
            }
            set {
            }
        }");
            }

            string name = Utils.PascalCase(entry.Name);
            if ((name == "jQueryUI") || (name == "Position")) {
                name = "";
            }
            string category = Utils.PascalCase(entry.Category);
            if ((category == "Widgets") && (name == "Widget")) {
                category = "";
                name = "";
            }
            Utils.CreateFile(Path.Combine(DestinationPath, category, name), className
                , string.Format(content
                                , className
                                , eventsContent.ToString()
                                , optionsContent.ToString()
                                , (entry.Name.ToLower() != "widget") ? "sealed" : string.Empty
                                , Utils.GetNamespace(entry)
                                , Utils.PascalCase(entry.Name)));
        }

        private void RenderEvents(Entry entry) {
            if (entry.Events.Count == 0) {
                return;
            }

            string content =
@"using System;
using System.Runtime.CompilerServices;

namespace {2} {{

    [Imported]
    [IgnoreNamespace]
    [ScriptName(""Object"")]
    public sealed class {0} {{{1}
    }}
}}";
            string property = @"

        [IntrinsicProperty]
        public {1} {0} {{
            get {{
                return {2};
            }}
            set {{
            }}
        }}";

            string className;

            foreach (var @event in entry.Events.AsQueryable()
                                          .OrderBy(e => e.Name)) {
                if (@event.Type.StartsWith("function")) continue;
                if (string.IsNullOrEmpty(@event.Type)) continue;

                string eventType = @event.Type.Replace(@event.Name.ToLower(), Utils.PascalCase(@event.Name));

                foreach (Argument arg in @event.Arguments) {
                    if (arg.Name != "ui") continue;
                    if (arg.Properties.Count == 0) continue;

                    className = Utils.PascalCase(eventType) + "Event";

                    StringBuilder properties = new StringBuilder();

                    foreach (Property prop in arg.Properties.OrderBy(p => p.Name)) {
                        properties.Append(string.Format(property, Utils.PascalCase(prop.Name), Utils.MapDataType(prop.Type), Utils.GetDefaultValue(prop.Type)));
                    }

                    Utils.CreateFile(Path.Combine(DestinationPath, Utils.PascalCase(entry.Category), Utils.PascalCase(entry.Name))
                                    , className
                                    , string.Format(content, className, properties.ToString(), Utils.GetNamespace(entry)));
                }
            }
        }

        private void RenderOptionEnum(Entry entry, Entry baseEntry = null) {
            if (entry.Options.Count == 0) {
                return;
            }

            string className = Utils.PascalCase(entry.Name) + @"Option";

            string content =
@"using System;
using System.Runtime.CompilerServices;

namespace {2} {{

    /// <summary>
    /// Options for use with {3}.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum {0} {{{1}
    }}
}}";
            StringBuilder enumValues = new StringBuilder();

            IEnumerable<Option> options = entry.Options.AsQueryable();

            if (baseEntry != null) {
                options = options.Union(baseEntry.Options);
            }

            foreach (var option in options.OrderBy(o => o.Name)
                                          .GroupBy(o => o.Name)) {
                enumValues.AppendLine();
                enumValues.AppendLine();
                if (!string.IsNullOrEmpty(option.Min(o => o.Description))) {
                    enumValues.AppendLine("        /// <summary>");
                    enumValues.AppendLine("        /// " + Utils.FormatXmlComment(option.Min(o => o.Description).Replace("<entryname />", entry.Name)));
                    enumValues.AppendLine("        /// </summary>");
                }
                enumValues.Append("        " + Utils.PascalCase(option.Key) + ",");
            }

            string name = Utils.PascalCase(entry.Name);
            if ((name == "jQueryUI") || (name == "Position")) {
                name = "";
            }
            string category = Utils.PascalCase(entry.Category);
            if ((category == "Widgets") && (name == "Widget")) {
                category = "";
                name = "";
            }
            Utils.CreateFile(Path.Combine(DestinationPath, category, name), className
                , string.Format(content, className, enumValues.ToString().Trim(','), Utils.GetNamespace(entry), Utils.PascalCase(entry.Name)));
        }

        private void RenderEventsEnum(Entry entry, Entry baseEntry = null) {
            if (entry.Events.Count == 0) {
                return;
            }

            string className = Utils.PascalCase(entry.Name) + @"Events";

            string content =
@"using System;
using System.Runtime.CompilerServices;

namespace {2} {{

    /// <summary>
    /// Events raised by {3}.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum {0} {{{1}
    }}
}}";
            StringBuilder enumValues = new StringBuilder();

            IEnumerable<Event> events = entry.Events.AsQueryable();

            if (baseEntry != null) {
                events = events.Union(baseEntry.Events);
            }

            foreach (var @event in events.OrderBy(e => e.Name)
                                         .GroupBy(e => e.Name)) {
                enumValues.AppendLine();
                enumValues.AppendLine();
                if (!string.IsNullOrEmpty(@event.Min(e => e.Description))) {
                    enumValues.AppendLine("        /// <summary>");
                    enumValues.AppendLine("        /// " + Utils.FormatXmlComment(@event.Min(e => e.Description).Replace("<entryname />", entry.Name)));
                    enumValues.AppendLine("        /// </summary>");
                }
                enumValues.Append("        " + Utils.PascalCase(@event.Key) + ",");
            }

            string name = Utils.PascalCase(entry.Name);
            if ((name == "jQueryUI") || (name == "Position")) {
                name = "";
            }
            string category = Utils.PascalCase(entry.Category);
            if ((category == "Widgets") && (name == "Widget")) {
                category = "";
                name = "";
            }
            Utils.CreateFile(Path.Combine(DestinationPath, category, name), className
                , string.Format(content, className, enumValues.ToString().Trim(','), Utils.GetNamespace(entry), Utils.PascalCase(entry.Name)));
        }

        private void RenderMethodEnum(Entry entry, Entry baseEntry = null) {
            if (entry.Methods.Count == 0) {
                return;
            }

            if (entry.Methods.Where(m => !excludeJQueryMethods.Contains(m.Name.ToLower())).Count() == 0) {
                return;
            }

            string className = Utils.PascalCase(entry.Name) + @"Method";

            string content =
@"using System;
using System.Runtime.CompilerServices;

namespace {2} {{

    /// <summary>
    /// Operations supported by {3}.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum {0} {{{1}
    }}
}}";
            StringBuilder enumValues = new StringBuilder();

            IEnumerable<Method> methods = entry.Methods.AsQueryable();

            if (baseEntry != null) {
                methods = methods.Union(baseEntry.Methods
                    // filter private methods from the base entry
                                                 .Where(m => !m.Name.StartsWith("_")))
                                 .Where(m => !excludeJQueryMethods.Contains(m.Name.ToLower()));
            }

            foreach (var method in methods.OrderBy(m => m.Name)
                                          .GroupBy(m => m.Name)) {
                enumValues.AppendLine();
                enumValues.AppendLine();
                if (!string.IsNullOrEmpty(method.Min(m => m.Description))) {
                    enumValues.AppendLine("        /// <summary>");
                    enumValues.AppendLine("        /// " + Utils.FormatXmlComment(method.Min(m => m.Description).Replace("<entryname />", entry.Name)));
                    enumValues.AppendLine("        /// </summary>");
                }
                if (Utils.PascalCase(method.Key).ToLower() != method.Key.ToLower()) {
                    enumValues.AppendLine("        [ScriptName(\"" + method.Key + "\")]");
                }
                enumValues.Append("        " + Utils.PascalCase(method.Key) + ",");
            }

            string name = Utils.PascalCase(entry.Name);
            if ((name == "jQueryUI") || (name == "Position")) {
                name = "";
            }
            string category = Utils.PascalCase(entry.Category);
            if ((category == "Widgets") && (name == "Widget")) {
                category = "";
                name = "";
            }
            Utils.CreateFile(Path.Combine(DestinationPath, category, name), className
                , string.Format(content, className, enumValues.ToString().Trim(','), Utils.GetNamespace(entry), Utils.PascalCase(entry.Name)));
        }

        private void RenderEventHandler() {
            string className = "jQueryUIEventHandler";

            string content =
@"using System;
using System.Runtime.CompilerServices;

namespace " + Utils.GetNamespace(null) + @" {

    /// <summary>
    /// Handles a widget event.
    /// </summary>
    /// <typeparam name=""T"">The type of the widget event object.</typeparam>
    /// <param name=""e"">The associated jQuery event object.</param>
    /// <param name=""uiEvent"">The widget event information.</param>
    [Imported]
    [IgnoreNamespace]
    public delegate void " + className + @"<T>(jQueryEvent e, T uiEvent);
}";

            Messages.WriteLine("Generating " + Path.Combine(DestinationPath, className));
            Utils.CreateFile(DestinationPath, className, content);
        }

        private void RenderJQueryUI() {
            string className = "jQueryUI";

            string content =
@"using System;
using System.Runtime.CompilerServices;

namespace " + Utils.GetNamespace(null) + @" {

    /// <summary>
    /// Top-level jQueryUI methods.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName(""$"")]
    public static class jQueryUI {

        /// <summary>
        /// Exposes the widget with the specified name on the top-level jQuery API.
        /// </summary>
        /// <param name=""name"">The name of the widget.</param>
        /// <param name=""widget"">The widget object.</param>
        [ScriptName(""widget.bridge"")]
        public static void Bridge(string name, object widget) {
        }

        /// <summary>
        /// Create stateful jQuery plugins using the same abstraction that all jQuery UI widgets.
        /// </summary>
        /// <param name=""name"">The name of the widget.</param>
        /// <param name=""widget"">The widget object.</param>
        [ScriptName(""widget"")]
        public static WidgetObject CreateWidget(string name, object widget) {
            return null;
        }

        /// <summary>
        /// Create stateful jQuery plugins using the same abstraction that all jQuery UI widgets.
        /// </summary>
        /// <param name=""name"">The name of the widget.</param>
        /// <param name=""baseWidgetType"">The widget type to inherit from.</param>
        /// <param name=""widget"">The widget object.</param>
        [ScriptName(""widget"")]
        public static WidgetObject CreateWidget(string name, WidgetType baseWidgetType, object widget) {
            return null;
        }

        /// <summary>
        /// Create stateful jQuery plugins using the same abstraction that all jQuery UI widgets.
        /// </summary>
        /// <param name=""name"">The name of the widget.</param>
        /// <param name=""baseWidgetType"">The widget type to inherit from.</param>
        /// <param name=""widget"">The widget object.</param>
        [ScriptName(""widget"")]
        public static WidgetObject CreateWidget(string name, object baseWidgetType, object widget) {
            return null;
        }
    }
}";
            Messages.WriteLine("Generating " + Path.Combine(DestinationPath, className));
            Utils.CreateFile(DestinationPath, className, content);
        }

        private void RenderWidgetType(IList<Entry> entries) {
            string className = "WidgetType";

            string content =
@"using System;
using System.Runtime.CompilerServices;

namespace {0} {{

    /// <summary>
    /// The default widgets that are part of jQueryUI.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName(""$.ui"")]
    public sealed class WidgetType {{

         private WidgetType() {{
         }}
         {1}
    }}
}}";
            StringBuilder fields = new StringBuilder();

            foreach (Entry entry in entries) {
                if (!string.IsNullOrEmpty(entry.Type)) {
                    if (entry.Type.ToLower() == "widget") {
                        fields.AppendLine();
                        fields.Append("         ");
                        fields.Append("public static readonly WidgetType ");
                        fields.Append(Utils.PascalCase(entry.Name));
                        fields.AppendLine(" = null;");
                    }
                }
            }

            Messages.WriteLine("Generating " + Path.Combine(DestinationPath, className));
            Utils.CreateFile(DestinationPath
                            , className
                            , string.Format(content, Utils.GetNamespace(null), fields.ToString()));
        }

        /// <summary>
        /// Renders project file with included all generated files.
        /// </summary>
        /// <param name="entries">List of jQueryUI entries.</param>
        public void RenderProjectFile(IList<Entry> entries) {
            string content = @"<?xml version=""1.0"" encoding=""utf-8""?>
<Project ToolsVersion=""4.0"" DefaultTargets=""Build"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">
  <PropertyGroup>
    <Configuration Condition="" '$(Configuration)' == '' "">Debug</Configuration>
    <Platform Condition="" '$(Platform)' == '' "">AnyCPU</Platform>
    <ProductVersion>9.0.30729</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{824C1FEC-2455-4183-AFC6-891EDB88213A}</ProjectGuid>
    <OutputType>Library</OutputType>
    <NoStdLib>True</NoStdLib>
    <SignAssembly>true</SignAssembly>
    <AssemblyOriginatorKeyFile>..\..\..\ScriptSharp.snk</AssemblyOriginatorKeyFile>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>jQueryApi.UI</RootNamespace>
    <AssemblyName>Script.jQuery.UI</AssemblyName>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <TargetFrameworkProfile />
  </PropertyGroup>
  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' "">
    <DebugSymbols>false</DebugSymbols>
    <Optimize>false</Optimize>
    <DefineConstants>DEBUG</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <OutputPath>..\..\..\..\bin\Debug\</OutputPath>
    <DocumentationFile>..\..\..\..\bin\Debug\Script.jQuery.UI.xml</DocumentationFile>
    <NoWarn>1591, 0661, 0660, 1684</NoWarn>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
  </PropertyGroup>
  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' "">
    <DebugSymbols>false</DebugSymbols>
    <DebugType>none</DebugType>
    <Optimize>true</Optimize>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <OutputPath>..\..\..\..\bin\Release\</OutputPath>
    <DocumentationFile>..\..\..\..\bin\Release\Script.jQuery.UI.xml</DocumentationFile>
    <NoWarn>1591, 0661, 0660, 1684</NoWarn>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
  </PropertyGroup>
  <ItemGroup>
";
            bool includedRootFiles = false;
            foreach (Entry entry in entries) {
                string name = Utils.PascalCase(entry.Name);
                if ((name == "jQueryUI") || (name == "Position")) {
                    if (includedRootFiles == false) {
                        content += @"    <Compile Include=""*.cs"" />
";
                        includedRootFiles = true;
                    }
                    continue;
                }
                string category = Utils.PascalCase(entry.Category);
                if ((category == "Widgets") && (name == "Widget")) {
                    continue;
                }
                content += @"    <Compile Include=""" + Path.Combine(Utils.PascalCase(entry.Category), name) + @"\*.cs"" />
";
            }

            content += @"    <Compile Include=""Properties\AssemblyInfo.cs"" />
    <Compile Include=""..\..\..\ScriptSharp.cs"">
      <Link>Properties\ScriptSharp.cs</Link>
    </Compile>
    <ScriptInfo Include=""Properties\ScriptInfo.txt"">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </ScriptInfo>
  </ItemGroup>
  <ItemGroup>
    <ProjectReference Include=""..\..\CoreLib\CoreLib.csproj"">
      <Project>{36D4B098-A21C-4725-ACD3-400922885F38}</Project>
      <Name>CoreLib</Name>
    </ProjectReference>
    <ProjectReference Include=""..\..\Web\Web.csproj"">
      <Project>{3681A9A8-FC40-4125-B842-7775713C8DCE}</Project>
      <Name>Web</Name>
    </ProjectReference>
    <ProjectReference Include=""..\jQuery.Core\jQuery.Core.csproj"">
      <Project>{4A9F7CE0-5A45-4B28-AD01-05528709B6E4}</Project>
      <Name>jQuery.Core</Name>
    </ProjectReference>
  </ItemGroup>
  <Import Project=""$(MSBuildBinPath)\Microsoft.CSharp.targets"" />
  <Target Name=""AfterBuild"">
    <Copy SourceFiles=""@(ScriptInfo)"" DestinationFiles=""$(OutputPath)$(AssemblyName).txt"" />
  </Target>
</Project>";

            using (StreamWriter file = new StreamWriter(Path.Combine(DestinationPath, "jQuery.UI.csproj"))) {
                file.WriteLine(content);
            }

            // render assembly information
            string assemblyContent = @"﻿
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: AssemblyTitle(""Script.jQuery.UI"")]
[assembly: AssemblyDescription(""Script# jQuery UI Plugin"")]
[assembly: ScriptAssembly(""jQueryUI"")]";

            Utils.CreateFile(Path.Combine(DestinationPath, "Properties"), "AssemblyInfo", assemblyContent);

            // render script information
            string infoContent = @"jQuery UI
===============================================================================

This assembly provides access to jQuery UI APIs. This is only meant for use at
development time, so you can reference and compile your c# code against 
the plugin APIs. You must include the appropriate plugin scripts in your page for 
runtime functionality.

More information is on http://jqueryui.com.

-------------------------------------------------------------------------------

Associated scripts can be found at
http://jqueryui.com/download";

            using (StreamWriter file = new StreamWriter(Path.Combine(DestinationPath, "Properties", "ScriptInfo.txt"))) {
                file.WriteLine(infoContent);
            }
        }
    }
}
