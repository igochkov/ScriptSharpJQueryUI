// SpinnerOptions.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Options used to initialize or customize Spinner.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public sealed class SpinnerOptions {

        public SpinnerOptions() {
        }

        public SpinnerOptions(params object[] nameValuePairs) {
        }

        /// <summary>
        /// Triggered when the value of the spinner has changed and the input is no longer focused.
        /// </summary>
        [IntrinsicProperty]
        public jQueryUIEventHandler<jQueryObject> Change {
             get {
                return null;
             }
             set {
             }
        }

        /// <summary>
        /// This event is triggered when the spinner is created.
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
        /// Triggered during increment/decrement (to determine direction of spin compare current value with ui.value).<para>Can be cancelled, preventing the provided value to be set, firing <code>stop</code> and, if appropiate, <code>change</code> events.</para>
        /// </summary>
        [IntrinsicProperty]
        public jQueryUIEventHandler<SpinEvent> Spin {
             get {
                return null;
             }
             set {
             }
        }

        /// <summary>
        /// Triggered before a spin. Can be cancelled, preventing all other events to fire.
        /// </summary>
        [IntrinsicProperty]
        public jQueryUIEventHandler<jQueryObject> Start {
             get {
                return null;
             }
             set {
             }
        }

        /// <summary>
        /// Triggered after a spin.
        /// </summary>
        [IntrinsicProperty]
        public jQueryUIEventHandler<jQueryObject> Stop {
             get {
                return null;
             }
             set {
             }
        }

        /// <summary>
        /// Sets the culture to use for parsing and formatting the value, if null, the currently set culture in Globalization is used, see Globalization docs for available cultures. Only relevant if the <code>numberFormat</code> option is set.
        /// </summary>
        [IntrinsicProperty]
        public string Culture {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// Disables the spinner if set to true.
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
        /// Controls the number of steps taken when holding down a spin button.<ul><li>a boolean<ul><li>when set to true, the stepping delta will increase when spun incessantly</li><li>when set to false, all steps are equal (as defined by the step option)</li></ul></li><li>a function<ul><li>receives the number of spins that have occurred as a parameter</li><li>must return the number of steps that should occur for the current spin</li></ul></li></ul>
        /// </summary>
        [IntrinsicProperty]
        public object Incremental {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// The maximum allowed value.<para>The element's <code>max</code> attribute is used if it exists and the option is not explicitly set.</para><para>The max option can be passed as string which will be parsed based on numberFormat and culture or just using native parseFloat.</para><para>If null, there is no maximum enforced.</para>
        /// </summary>
        [IntrinsicProperty]
        public object Max {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// The minimum allowed value.<para>The element's <code>min</code> attribute is used if it exists and the option is not explicitly set.</para><para>The min option can be passed as string which will be parsed based on numberFormat and culture or just using native parseFloat.</para><para>If null, there is no minimum enforced.</para>
        /// </summary>
        [IntrinsicProperty]
        public object Min {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// Format of numbers passed to Globalize, if available. Most common are 'n' for a decimal number and 'C' for a currency value.
        /// </summary>
        [IntrinsicProperty]
        public string NumberFormat {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// The number of steps to take when paging via the pageUp()/pageDown() methods.
        /// </summary>
        [IntrinsicProperty]
        public int Page {
            get {
                return 0;
            }
            set {
            }
        }

        /// <summary>
        /// The size of step to take when spinning via buttons or via the stepUp()/stepDown() methods.<para>The element's <code>step</code> attribute is used if it exists and the option is not explicitly set.</para><para>Can be passed as string which will be parsed based on numberFormat and culture or just using native parseFloat.</para>
        /// </summary>
        [IntrinsicProperty]
        public object Step {
            get {
                return null;
            }
            set {
            }
        }
    }
}
