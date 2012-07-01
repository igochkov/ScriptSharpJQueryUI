// TabsEvents.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum TabsEvents {

        /// <summary>
        /// Triggered after a tab has been activated and the associated panels have been shown and hidden.
        /// </summary>
        Activate,

        /// <summary>
        /// Triggered after a new tab is added.
        /// </summary>
        Add,

        /// <summary>
        /// Triggered directly after a tab is activated. Can be cancelled to prevent the tab from activating.
        /// </summary>
        BeforeActivate,

        /// <summary>
        /// Triggered after beforeActivate for a remote tab. Can be cancelled to prevent the tab panel from loading content.
        /// </summary>
        BeforeLoad,

        /// <summary>
        /// This event is triggered when the tabs widget is created.
        /// </summary>
        Create,

        /// <summary>
        /// Triggered after an enabled tab has been disabled.
        /// </summary>
        Disable,

        /// <summary>
        /// Triggered after a disabled tab has been enabled.
        /// </summary>
        Enable,

        /// <summary>
        /// Triggered after a remote tab has been loaded.
        /// </summary>
        Load,

        /// <summary>
        /// Triggered after a tab has been removed.
        /// </summary>
        Remove,

        /// <summary>
        /// Triggered after a tab has been shown.
        /// </summary>
        Show
    }
}
