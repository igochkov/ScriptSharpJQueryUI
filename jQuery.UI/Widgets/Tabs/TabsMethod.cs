// TabsMethod.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum TabsMethod {

        /// <summary>
        /// Disable a tab. The selected tab cannot be disabled. To disable more than one tab at once use: <code>$('#example').tabs("option","disabled", [1, 2, 3]);</code><para>The argument is the zero-based index of the tab to be disabled. Instead of an index, the href of the tab may be passed.</para>
        /// </summary>
        Disable,

        /// <summary>
        /// Enable a disabled tab. To enable more than one tab at once reset the disabled property like: <code>$('#example').tabs("option","disabled",[]);</code>.<para>The argument is the zero-based index of the tab to be enabled. Instead of an index, the href of the tab may be passed.</para>
        /// </summary>
        Enable,

        /// <summary>
        /// Load the panel content of a remote tab (specified by index)
        /// </summary>
        Load
    }
}
