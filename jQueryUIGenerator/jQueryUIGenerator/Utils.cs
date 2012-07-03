// Utils.cs
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

using System.IO;
using System.Linq;
using ScriptSharp.Tools.jQueryUIGenerator.Model;

namespace ScriptSharp.Tools.jQueryUIGenerator {
    public static class Utils {
        /// <summary>
        /// Creates file with the specified content
        /// </summary>
        /// <param name="outputPath">Output location.</param>
        /// <param name="fileName">Name of the file to be generated (without extension ). Extension .cs will be added.</param>
        /// <param name="content">File content.</param>
        public static void CreateFile(string outputPath, string fileName, string content) {
            DirectoryInfo dir = new DirectoryInfo(outputPath);

            if (!dir.Exists) {
                dir.Create();
            }

            using (StreamWriter file = new StreamWriter(Path.Combine(dir.FullName, fileName + ".cs"))) {
                file.WriteLine(GetFileHeader(fileName + ".cs"));
                file.WriteLine(content);
            }
        }

        /// <summary>
        /// Formats the given text in form sutable for Xml documentation comments.
        /// </summary>
        /// <param name="text">Text to be formated.</param>
        /// <returns>Formated text.</returns>
        public static string FormatXmlComment(string text) {
            if (string.IsNullOrEmpty(text)) {
                return string.Empty;
            }

            return text.Replace("<p>", "<para>")
                       .Replace("</p>", "</para>")
                       .Replace("<pre>", "<c>")
                       .Replace("</pre>", "</c>")
                       .Replace("<nowiki>", "<c>")
                       .Replace("</nowiki>", "</c>")
                       .Replace("\r", "")
                       .Replace("\n", "")
                       .Replace("\t", "")
                       .Replace("<![CDATA[", "")
                       .Replace("]]>", "")
                       .Trim('|')
                       .Trim();
        }

        /// <summary>
        /// Gets the file header.
        /// </summary>
        /// <param name="fileName">File name.</param>
        /// <returns>File header.</returns>
        private static string GetFileHeader(string fileName) {
            string header =
@"// {0}
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
";

            return string.Format(header, fileName);
        }

        /// <summary>
        /// Gets namespace for an entry
        /// </summary>
        /// <param name="entry">Entry to be generated</param>
        /// <returns>The namespace</returns>
        public static string GetNamespace(Entry entry) {
            string @namespace = "jQueryApi.UI";

            if (entry == null) {
                return @namespace;
            }

            if (entry.Name.ToLower() == "widget" || entry.Category.ToLower() == "utilities") {
                return @namespace;
            }

            if (string.IsNullOrEmpty(entry.Category)) {
                return @namespace;
            }

            return @namespace + "." + PascalCase(entry.Category);
        }

        /// <summary>
        /// Translates data type found in jQueryUI documentation to appropriate C# data type.
        /// </summary>
        /// <param name="type">jQueryUI data type.</param>
        /// <returns>CS data type.</returns>
        public static string MapDataType(string type) {
            if (SplitType(type).Length > 1) {
                // jQueryUI documentation uses atribute "type" which is a collection of data types.
                // example: <argument name="index" type="Number, String">
                // According to api.jqueryui.com, in the future the "type" attribute 
                // will be replaced with list of child elements 
                // example: <type name="Number" /><type name="String" />
                return "object";
            } else {
                switch (type.ToLower()) {
                    case "integer":
                    case "number":
                        return "int";
                    case "float":
                        return "float";
                    case "hash":
                    case "options":
                    case "object":
                    case "":
                        return "object";
                    case "selector":
                    case "element":
                    case "string":
                        return "string";
                    case "boolean":
                        return "bool";
                    case "function":
                        return "Action";
                    case "jquery":
                        return "jQueryObject";
                    case "widget":
                        return "WidgetObject";
                    case "event":
                        return "jQueryEvent";
                    case "rest":
                        return "params object[]";
                    default:
                        return type;
                }
            }
        }

        /// <summary>
        /// Gets default value of a C# data type.
        /// </summary>
        /// <param name="type">C# data type.</param>
        /// <returns>Default value.</returns>
        public static string GetDefaultValue(string type) {
            string csType = MapDataType(type);

            switch (csType.ToLower()) {
                case "int":
                case "float":
                    return "0";
                case "bool":
                    return "false";
                default:
                    return "null";
            }
        }

        /// <summary>
        /// Converts the name into a pascal-cased name.
        /// </summary>
        /// <param name="word">Word to be pascal-cased.</param>
        /// <returns>Pascal-cased word.</returns>
        public static string PascalCase(string word) {
            if (string.IsNullOrEmpty(word)) {
                return string.Empty;
            }

            // Quick and dirty way to cover specific multi-word names
            // using simple rules
            word = word.Replace("ui", "jQueryUI")
                       .Replace("autocomplete", "AutoComplete")
                       .Replace("datepicker", "DatePicker")
                       .Replace("progressbar", "ProgressBar")
                       .Replace("tabsselect", "TabsSelect")
                       .Replace("tabsload", "TabsLoad")
                       .TrimStart('_');

            if (word.StartsWith("jQuery")) {
                return word;
            } else {
                return char.ToUpper(word[0]) + word.Substring(1);
            }
        }

        /// <summary>
        /// Splits jQueryUI entry types
        /// </summary>
        /// <param name="type">jQueryUI entry type</param>
        /// <returns>List with jQueryUI entry types</returns>
        public static string[] SplitType(string type) {
            if (string.IsNullOrEmpty(type)) {
                return new string[] { };
            }

            return type.Split(new char[] { ',', '/', ' ', '|' }).Where(s => s != "or").ToArray();
        }
    }
}
