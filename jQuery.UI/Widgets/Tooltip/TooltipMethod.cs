// TooltipMethod.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum TooltipMethod {

        /// <summary>
        /// Programmatically close a tooltip. Sames rules as for <code>open</code> method.
        /// </summary>
        Close,

        /// <summary>
        /// Programmatically open a tooltip. If the widget's element is the target, the event argument is optional. Otherwise you have to pass an event object with the <code>currentTarget</code> property pointing at the target.
        /// </summary>
        Open
    }
}
