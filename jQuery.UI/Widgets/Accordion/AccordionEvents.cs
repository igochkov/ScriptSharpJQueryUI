// AccordionEvents.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum AccordionEvents {

        /// <summary>
        /// Triggered directly after a panel is activated. Can be cancelled to prevent the panel from activating.
        /// </summary>
        Activate,

        /// <summary>
        /// Triggered after a accordion panel has been activated (after animation completes).
        /// </summary>
        BeforeActivate,

        /// <summary>
        /// This event is triggered when the accordion is created.
        /// </summary>
        Create
    }
}
