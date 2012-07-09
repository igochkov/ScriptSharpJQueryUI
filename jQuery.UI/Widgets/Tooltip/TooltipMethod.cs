// TooltipMethod.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Operations supported by Tooltip.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum TooltipMethod {

        /// <summary>
        /// Programmatically close a tooltip. Sames rules as for <code>open</code> method.
        /// </summary>
        Close,

        /// <summary>
        /// The <code>destroy()</code> method cleans up all common data, events, etc. and then delegates out to <code>_destroy()</code> for custom cleanup.
        /// </summary>
        Destroy,

        Disable,

        Enable,

        /// <summary>
        /// Programmatically open a tooltip. If the widget's element is the target, the event argument is optional. Otherwise you have to pass an event object with the <code>currentTarget</code> property pointing at the target.
        /// </summary>
        Open,

        Option,

        Widget
    }
}
