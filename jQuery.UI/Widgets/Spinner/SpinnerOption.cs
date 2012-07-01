// SpinnerOption.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum SpinnerOption {

        /// <summary>
        /// Sets the culture to use for parsing and formatting the value, if null, the currently set culture in Globalization is used, see Globalization docs for available cultures. Only relevant if the <code>numberFormat</code> option is set.
        /// </summary>
        Culture,

        /// <summary>
        /// Disables the spinner if set to true.
        /// </summary>
        Disabled,

        /// <summary>
        /// Controls the number of steps taken when holding down a spin button.<ul><li>a boolean<ul><li>when set to true, the stepping delta will increase when spun incessantly</li><li>when set to false, all steps are equal (as defined by the step option)</li></ul></li><li>a function<ul><li>receives the number of spins that have occurred as a parameter</li><li>must return the number of steps that should occur for the current spin</li></ul></li></ul>
        /// </summary>
        Incremental,

        /// <summary>
        /// The maximum allowed value.<para>The element's <code>max</code> attribute is used if it exists and the option is not explicitly set.</para><para>The max option can be passed as string which will be parsed based on numberFormat and culture or just using native parseFloat.</para><para>If null, there is no maximum enforced.</para>
        /// </summary>
        Max,

        /// <summary>
        /// The minimum allowed value.<para>The element's <code>min</code> attribute is used if it exists and the option is not explicitly set.</para><para>The min option can be passed as string which will be parsed based on numberFormat and culture or just using native parseFloat.</para><para>If null, there is no minimum enforced.</para>
        /// </summary>
        Min,

        /// <summary>
        /// Format of numbers passed to Globalize, if available. Most common are 'n' for a decimal number and 'C' for a currency value.
        /// </summary>
        NumberFormat,

        /// <summary>
        /// The number of steps to take when paging via the pageUp()/pageDown() methods.
        /// </summary>
        Page,

        /// <summary>
        /// The size of step to take when spinning via buttons or via the stepUp()/stepDown() methods.<para>The element's <code>step</code> attribute is used if it exists and the option is not explicitly set.</para><para>Can be passed as string which will be parsed based on numberFormat and culture or just using native parseFloat.</para>
        /// </summary>
        Step
    }
}
