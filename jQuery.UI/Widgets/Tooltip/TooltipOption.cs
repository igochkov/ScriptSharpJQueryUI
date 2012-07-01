// TooltipOption.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum TooltipOption {

        /// <summary>
        /// The content of the tooltip. The callback can either return the content directly, or call the first argument, passing in the content, eg. for ajax content.When changing this option, you likely need to also change the items option.
        /// </summary>
        Content,

        /// <summary>
        /// Disables the tooltip if set to true.
        /// </summary>
        Disabled,

        /// <summary>
        /// How to hide the tooltip.
        /// </summary>
        Hide,

        /// <summary>
        /// A selector matched when activating a tooltip. Customize if you're using something other then the title attribute for the tooltip content, or if you need a different selector for event delegation.When changing this option, you likely need to also change the content option.
        /// </summary>
        Items,

        /// <summary>
        /// Configuration for the Position  utility. The of property defaults to the target element, but can also be overriden.
        /// </summary>
        Position,

        /// <summary>
        /// How to show the tooltip.
        /// </summary>
        Show,

        /// <summary>
        /// A class to add to the widget, can be used to display various tooltip types, like warnings or errors.<para>This may get replaced by the <a href="http://bugs.jqueryui.com/ticket/7053">classes option</a>.</para>
        /// </summary>
        TooltipClass,

        /// <summary>
        /// Whether the tooltip should track (follow) the mouse.
        /// </summary>
        Track
    }
}
