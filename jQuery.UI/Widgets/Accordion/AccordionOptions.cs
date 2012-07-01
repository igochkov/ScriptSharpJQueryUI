// AccordionOptions.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public sealed class AccordionOptions {

        public AccordionOptions() {
        }

        public AccordionOptions(params object[] nameValuePairs) {
        }

        /// <summary>
        /// Triggered directly after a panel is activated. Can be cancelled to prevent the panel from activating.
        /// </summary>
        [IntrinsicProperty]
        public jQueryUIEventHandler<AccordionActivateEvent> Activate {
             get {
                return null;
             }
             set {
             }
        }

        /// <summary>
        /// Triggered after a accordion panel has been activated (after animation completes).
        /// </summary>
        [IntrinsicProperty]
        public jQueryUIEventHandler<AccordionBeforeActivateEvent> BeforeActivate {
             get {
                return null;
             }
             set {
             }
        }

        /// <summary>
        /// This event is triggered when the accordion is created.
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
        /// The zero-based index of the panel that is active (open). A negative value select panels going backward from the last panel.<para>When collapsible is set to true, a false value closes the accordion, otherwise nothing happens</para>
        /// </summary>
        [IntrinsicProperty]
        public object Active {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// If and how to animate changing panels:<ul><li>string; name of easing to use with default duration</li><li>number, duration in milliseconds with default easing</li><li>object with easing and duration options</li><li>can also contain a down option with any of the above options</li><li>"down" animations occur when the panel being activated has a lower index than the currently active panel</li><li>null/false disables animation</li></ul>
        /// </summary>
        [IntrinsicProperty]
        public object Animate {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// Whether all the sections can be closed at once. Allows collapsing the active section.
        /// </summary>
        [IntrinsicProperty]
        public bool Collapsible {
            get {
                return false;
            }
            set {
            }
        }

        /// <summary>
        /// Disables the accordion if set to true.
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
        /// The event on which to trigger the accordion.
        /// </summary>
        [IntrinsicProperty]
        public string Event {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// Selector for the header element.<para>Must be a selector that applies to the accordion container element, via .find()</para><para>The default covers both ul/li accordions, as well as flat structures like dl/dt/dd</para>
        /// </summary>
        [IntrinsicProperty]
        public string Header {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// Controls the height of the accordion and each panel. Possible values:<ul><li>auto: all panels will be set to the height of the tallest panel</li><li>fill: expand to the available height based on the accordion's parent height</li><li>content: each panel will be only as tall as its content</li></ul>
        /// </summary>
        [IntrinsicProperty]
        public string HeightStyle {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// Icons to use for headers, matching an icon defined by the jQuery UI CSS Framework. Set to false to have no icons displayed.<ul><li>header (string, default: "ui-icon-triangle-1-e")</li><li>activeHeader (string, default: "ui-icon-triangle-1-s")</li></ul>
        /// </summary>
        [IntrinsicProperty]
        public object Icons {
            get {
                return null;
            }
            set {
            }
        }
    }
}
