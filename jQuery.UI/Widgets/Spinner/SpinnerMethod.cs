// SpinnerMethod.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Operations supported by Spinner.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum SpinnerMethod {

        /// <summary>
        /// The <code>destroy()</code> method cleans up all common data, events, etc. and then delegates out to <code>_destroy()</code> for custom cleanup.
        /// </summary>
        Destroy,

        Disable,

        Enable,

        Option,

        /// <summary>
        /// Decrements the value by the specified number of pages, as defined by the page-option. Without the parameter, a single page is decremented.
        /// </summary>
        PageDown,

        /// <summary>
        /// Increments the value by the specified number of pages, as defined by the page-option. Without the parameter, a single page is incremented.
        /// </summary>
        PageUp,

        /// <summary>
        /// Decrements the value by the specified number of steps. Without the parameter, a single step is decremented.<para>If the resulting value is above the max or below the min, the value will be adjusted to the closest max or min.</para><para>If the resulting value is a step mismatch, the value will be adjusted to the closest step.</para>
        /// </summary>
        StepDown,

        /// <summary>
        /// Increments the value by the specified number of steps. Without the parameter, a single step is incremented.<o>If the resulting value is above the max or below the min, the value will be adjusted to the closest max or min.</o><para>If the resulting value is a step mismatch, the value will be adjusted to the closest step.</para>
        /// </summary>
        StepUp,

        /// <summary>
        /// Get or set the current value. Without the value parameter, returns the current value as a parsed number. Otherwise, sets the value.<para>If the value parameter is a string, its parsed based on the <code>numberFormat</code> and <code>culture</code> options.</para>
        /// </summary>
        Value,

        Widget
    }
}
