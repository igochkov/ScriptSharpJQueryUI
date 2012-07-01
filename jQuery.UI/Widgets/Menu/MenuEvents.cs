// MenuEvents.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum MenuEvents {

        /// <summary>
        /// Triggered when the menu loses focus.
        /// </summary>
        Blur,

        /// <summary>
        /// This event is triggered when the menu is created.
        /// </summary>
        Create,

        /// <summary>
        /// Triggered when a menu gains focus or when any menu item is activated via mouseover, click or keyboard interaction.
        /// </summary>
        Focus,

        /// <summary>
        /// Triggered when a menu item is selected either via click or enter key.
        /// </summary>
        Select
    }
}
