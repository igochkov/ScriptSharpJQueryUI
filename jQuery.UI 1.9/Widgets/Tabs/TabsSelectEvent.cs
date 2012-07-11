// TabsSelectEvent.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public sealed class TabsSelectEvent {

        [IntrinsicProperty]
        public jQueryObject NewPanel {
            get {
                return null;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public jQueryObject NewTab {
            get {
                return null;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public jQueryObject OldPanel {
            get {
                return null;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public jQueryObject OldTab {
            get {
                return null;
            }
            set {
            }
        }
    }
}
