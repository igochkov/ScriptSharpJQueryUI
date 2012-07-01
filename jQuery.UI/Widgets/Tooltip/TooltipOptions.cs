// TooltipOptions.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public sealed class TooltipOptions {

        public TooltipOptions() {
        }

        public TooltipOptions(params object[] nameValuePairs) {
        }

        /// <summary>
        /// Triggered when a tooltip is shown, triggered on focusin or mouseover.
        /// </summary>
        [IntrinsicProperty]
        public jQueryUIEventHandler<TooltipCloseEvent> Close {
             get {
                return null;
             }
             set {
             }
        }

        /// <summary>
        /// This event is triggered when the tooltip is created.
        /// </summary>
        [IntrinsicProperty]
        public jQueryEventHandler Create {
             get {
                return null;
             }
             set {
             }
        }

        /// <summary>
        /// Triggered when a tooltip is shown, triggered on focusin or mouseover.Can be used further modify or position the widget, eg. have it follow the mouse movement.
        /// </summary>
        [IntrinsicProperty]
        public jQueryUIEventHandler<TooltipOpenEvent> Open {
             get {
                return null;
             }
             set {
             }
        }

        /// <summary>
        /// The content of the tooltip. The callback can either return the content directly, or call the first argument, passing in the content, eg. for ajax content.When changing this option, you likely need to also change the items option.
        /// </summary>
        [IntrinsicProperty]
        public Action Content {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// Disables the tooltip if set to true.
        /// </summary>
        [IntrinsicProperty]
        public bool Disabled {
            get {
                return false;
            }
            set {
            }
        }

        /// <summary>
        /// How to hide the tooltip.
        /// </summary>
        [IntrinsicProperty]
        public object Hide {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// A selector matched when activating a tooltip. Customize if you're using something other then the title attribute for the tooltip content, or if you need a different selector for event delegation.When changing this option, you likely need to also change the content option.
        /// </summary>
        [IntrinsicProperty]
        public string Items {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// Configuration for the Position  utility. The of property defaults to the target element, but can also be overriden.
        /// </summary>
        [IntrinsicProperty]
        public object Position {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// How to show the tooltip.
        /// </summary>
        [IntrinsicProperty]
        public object Show {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// A class to add to the widget, can be used to display various tooltip types, like warnings or errors.<para>This may get replaced by the <a href="http://bugs.jqueryui.com/ticket/7053">classes option</a>.</para>
        /// </summary>
        [IntrinsicProperty]
        public string TooltipClass {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// Whether the tooltip should track (follow) the mouse.
        /// </summary>
        [IntrinsicProperty]
        public bool Track {
            get {
                return false;
            }
            set {
            }
        }
    }
}
