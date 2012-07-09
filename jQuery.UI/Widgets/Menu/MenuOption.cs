// MenuOption.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Options for use with Menu.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum MenuOption {

        /// <summary>
        /// Disables the menu if set to true.
        /// </summary>
        Disabled,

        /// <summary>
        /// Selector for the elements that serve as the menu container, including sub-menus.
        /// </summary>
        Menus,

        /// <summary>
        /// Using the Position utility, sets where the sub-menus will open in relation to the activated item in the parent menu.
        /// </summary>
        Position,

        /// <summary>
        /// Customize the aria roles used for the menu and menu items. The default uses "menuitem" for items. Setting it to "listbox" will use "option" for items.
        /// </summary>
        Role
    }
}
