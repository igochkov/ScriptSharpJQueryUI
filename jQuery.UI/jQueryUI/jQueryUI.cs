// jQueryUI.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Runtime.CompilerServices;

namespace jQueryApi.UI {
    [Imported]
    [IgnoreNamespace]
    [ScriptName("$")]
    public static class jQueryUI {
        /// <summary>
        /// Create stateful jQuery plugins using the same abstraction that all jQuery UI widgets.
        /// </summary>
        [ScriptName("widget")]
        public static WidgetObject Create(string name, params object[] options) {
            return null;
        }
    }
}
