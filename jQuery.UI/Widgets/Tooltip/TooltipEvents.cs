// TooltipEvents.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum TooltipEvents {

        /// <summary>
        /// Triggered when a tooltip is shown, triggered on focusin or mouseover.
        /// </summary>
        Close,

        /// <summary>
        /// This event is triggered when the tooltip is created.
        /// </summary>
        Create,

        /// <summary>
        /// Triggered when a tooltip is shown, triggered on focusin or mouseover.Can be used further modify or position the widget, eg. have it follow the mouse movement.
        /// </summary>
        Open
    }
}
