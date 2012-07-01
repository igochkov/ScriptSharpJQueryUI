// jQueryUIWidget.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Utilities {
    [Imported]
    [IgnoreNamespace]
    [ScriptName("$")]
    public static class jQueryUIWidget {
        /// <summary>
        /// Create stateful jQuery plugins using the same abstraction that all jQuery UI widgets.
        /// </summary>
        /// <remarks>
        /// <para>You can create new widgets from scratch, using just the <code>$.Widget</code> object as base to inherit from, or you can explicitly inherit from existing jQuery UI or third-party widgets. Defining a widget with the same name as you inherit from even allows you to extend widgets in place.</para><para>For now, more details can be found at <a href="https://github.com/scottgonzalez/widget-factory-docs/">github.com/scottgonzalez/widget-factory-docs/</a></para>
        /// </remarks>
        [ScriptName("widget")]
        public static WidgetObject Create(string name, params object[] options) {
            return null;
        }
    }
}
