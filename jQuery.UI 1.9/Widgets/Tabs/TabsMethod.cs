// TabsMethod.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Operations supported by Tabs.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum TabsMethod {

        /// <summary>
        /// The <code>destroy()</code> method cleans up all common data, events, etc. and then delegates out to <code>_destroy()</code> for custom cleanup.
        /// </summary>
        Destroy,

        Disable,

        Enable,

        /// <summary>
        /// Load the panel content of a remote tab (specified by index)
        /// </summary>
        Load,

        Option,

        Widget
    }
}
