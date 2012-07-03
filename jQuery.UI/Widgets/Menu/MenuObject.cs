// MenuObject.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Themeable menu with mouse and keyboard interactions for navigation.
    /// </summary>
    /// <remarks>
    /// <para>A menu can be created from any valid markup as long as the elements have a strict parent/child relationship and each menu item has an anchor. The most commonly used element is the unordered list (UL):</para><c><ul id="menu"><li><a href="#">Item 1</a></li><li><a href="#">Item 2</a></li><li><a href="#">Item 3</a><ul><li><a href="#">Item 3-1</a></li><li><a href="#">Item 3-2</a></li><li><a href="#">Item 3-3</a></li><li><a href="#">Item 3-4</a></li><li><a href="#">Item 3-5</a></li></ul></li><li><a href="#">Item 4</a></li><li><a href="#">Item 5</a></li></ul></c><para>If you use a structure other than UL/LI, including using the same element for the menu and the menu items, use the <code>menus</code> option to specify a way to differentiate the two elements, eg. <code>menus: 'div.menuElement'</code>.</para><para>Any menu item can be disabled by adding the ui-state-disabled class to that element.</para><para>This widget requires some functional CSS, otherwise it won't work. If you build a custom theme, use the widget's specific CSS file as a starting point.</para>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public abstract class MenuObject : WidgetObject {

        protected MenuObject() {
        }

        [ScriptName("menu")]
        public MenuObject Menu() {
            return null;
        }

        [ScriptName("menu")]
        public MenuObject Menu(MenuOptions options) {
            return null;
        }

        [ScriptName("menu")]
        public object Menu(MenuMethod method, params object[] options) {
            return null;
        }

        /// <summary>
        /// Remove focus from a menu, reset any active element styles and trigger the menu blur event.
        /// </summary>
        public void Blur(jQueryEvent @event) {
        }


        /// <summary>
        /// Close the currently active sub-menu.
        /// </summary>
        public void Collapse(jQueryEvent @event) {
        }


        /// <summary>
        /// Close all open sub-menus.
        /// </summary>
        public void CollapseAll(jQueryEvent @event, bool all) {
        }


        /// <summary>
        /// Open the sub-menu below the currently active item, if it exists.
        /// </summary>
        public void Expand(jQueryEvent @event) {
        }


        /// <summary>
        /// Activate a particular menu item, begin opening any sub-menu if present and trigger the menu focus event.
        /// </summary>
        public void Focus(jQueryEvent @event, jQueryObject item) {
        }


        /// <summary>
        /// Returns a boolean value stating whether or not the currently active item is the first item in the menu.
        /// </summary>
        public void IsFirstItem() {
        }


        /// <summary>
        /// Returns a boolean value stating whether or not the currently active item is the last item in the menu.
        /// </summary>
        public void IsLastItem() {
        }


        /// <summary>
        /// Move active state to next menu item.
        /// </summary>
        public void Next(jQueryEvent @event) {
        }


        /// <summary>
        /// Move active state to first menu item below the bottom of a scrollable menu or the last item if not scrollable.
        /// </summary>
        public void NextPage(jQueryEvent @event) {
        }


        /// <summary>
        /// Move active state to previous menu item.
        /// </summary>
        public void Previous(jQueryEvent @event) {
        }


        /// <summary>
        /// Move active state to first menu item above the top of a scrollable menu or the first item if not scrollable.
        /// </summary>
        public void PreviousPage(jQueryEvent @event) {
        }


        /// <summary>
        /// Initializes sub-menus and menu items that have not already been initialized. New menu items, including sub-menus can be added to the menu or all of the contents of the menu can be replaced and then initialized with the refresh method.
        /// </summary>
        public void Refresh() {
        }


        /// <summary>
        /// Select the currently active menu item, collapse all sub-menus and trigger the menu select event.
        /// </summary>
        public void Select(jQueryEvent @event) {
        }

    }
}
