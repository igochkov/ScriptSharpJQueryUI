// MenuMethod.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum MenuMethod {

        /// <summary>
        /// Remove focus from a menu, reset any active element styles and trigger the menu blur event.
        /// </summary>
        Blur,

        /// <summary>
        /// Close the currently active sub-menu.
        /// </summary>
        Collapse,

        /// <summary>
        /// Close all open sub-menus.
        /// </summary>
        CollapseAll,

        /// <summary>
        /// Open the sub-menu below the currently active item, if it exists.
        /// </summary>
        Expand,

        /// <summary>
        /// Activate a particular menu item, begin opening any sub-menu if present and trigger the menu focus event.
        /// </summary>
        Focus,

        /// <summary>
        /// Returns a boolean value stating whether or not the currently active item is the first item in the menu.
        /// </summary>
        IsFirstItem,

        /// <summary>
        /// Returns a boolean value stating whether or not the currently active item is the last item in the menu.
        /// </summary>
        IsLastItem,

        /// <summary>
        /// Move active state to next menu item.
        /// </summary>
        Next,

        /// <summary>
        /// Move active state to first menu item below the bottom of a scrollable menu or the last item if not scrollable.
        /// </summary>
        NextPage,

        /// <summary>
        /// Move active state to previous menu item.
        /// </summary>
        Previous,

        /// <summary>
        /// Move active state to first menu item above the top of a scrollable menu or the first item if not scrollable.
        /// </summary>
        PreviousPage,

        /// <summary>
        /// Initializes sub-menus and menu items that have not already been initialized. New menu items, including sub-menus can be added to the menu or all of the contents of the menu can be replaced and then initialized with the refresh method.
        /// </summary>
        Refresh,

        /// <summary>
        /// Select the currently active menu item, collapse all sub-menus and trigger the menu select event.
        /// </summary>
        Select
    }
}
