// MenuOptions.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public sealed class MenuOptions {

        public MenuOptions() {
        }

        public MenuOptions(params object[] nameValuePairs) {
        }

        /// <summary>
        /// Triggered when the menu loses focus.
        /// </summary>
        [IntrinsicProperty]
        public jQueryUIEventHandler<MenuBlurEvent> Blur {
             get {
                return null;
             }
             set {
             }
        }

        /// <summary>
        /// This event is triggered when the menu is created.
        /// </summary>
        [IntrinsicProperty]
        public jQueryEventHandler Create {
             get {
                return null;
             }
             set {
             }
        }

        /// <summary>
        /// Triggered when a menu gains focus or when any menu item is activated via mouseover, click or keyboard interaction.
        /// </summary>
        [IntrinsicProperty]
        public jQueryUIEventHandler<MenuFocusEvent> Focus {
             get {
                return null;
             }
             set {
             }
        }

        /// <summary>
        /// Triggered when a menu item is selected either via click or enter key.
        /// </summary>
        [IntrinsicProperty]
        public jQueryUIEventHandler<MenuSelectEvent> Select {
             get {
                return null;
             }
             set {
             }
        }

        /// <summary>
        /// Disables the menu if set to true.
        /// </summary>
        [IntrinsicProperty]
        public bool Disabled {
            get {
                return false;
            }
            set {
            }
        }

        /// <summary>
        /// Selector for the elements that serve as the menu container, including sub-menus.
        /// </summary>
        [IntrinsicProperty]
        public string Menus {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// Using the Position utility, sets where the sub-menus will open in relation to the activated item in the parent menu.
        /// </summary>
        [IntrinsicProperty]
        public object Position {
            get {
                return null;
            }
            set {
            }
        }

        /// <summary>
        /// Customize the aria roles used for the menu and menu items. The default uses "menuitem" for items. Setting it to "listbox" will use "option" for items.
        /// </summary>
        [IntrinsicProperty]
        public string Role {
            get {
                return null;
            }
            set {
            }
        }
    }
}
