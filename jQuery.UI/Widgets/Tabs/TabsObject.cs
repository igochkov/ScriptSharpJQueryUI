// TabsObject.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// A single content area with multiple panels, each associated with a header in a list
    /// </summary>
    /// <remarks>
    /// <para>Tabs are generally used to break content into multiple sections that can be swapped to save space, much like an accordion.</para><para>By default a tab widget will swap between tabbed sections on click, but the events can be changed to onHover through an option. Tab content can be loaded via Ajax by setting an href on a tab.</para><para>This widget requires some functional CSS, otherwise it won't work. If you build a custom theme, use the widget's specific CSS file as a starting point.</para>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public abstract class TabsObject : WidgetObject {

        protected TabsObject() {
        }

        [ScriptName("tabs")]
        public TabsObject Tabs() {
            return null;
        }

        [ScriptName("tabs")]
        public TabsObject Tabs(TabsOptions options) {
            return null;
        }

        [ScriptName("tabs")]
        public object Tabs(TabsMethod method, params object[] options) {
            return null;
        }

        /// <summary>
        /// Disable a tab. The selected tab cannot be disabled. To disable more than one tab at once use: <code>$('#example').tabs("option","disabled", [1, 2, 3]);</code><para>The argument is the zero-based index of the tab to be disabled. Instead of an index, the href of the tab may be passed.</para>
        /// </summary>
        public void Disable(object index) {
        }


        /// <summary>
        /// Enable a disabled tab. To enable more than one tab at once reset the disabled property like: <code>$('#example').tabs("option","disabled",[]);</code>.<para>The argument is the zero-based index of the tab to be enabled. Instead of an index, the href of the tab may be passed.</para>
        /// </summary>
        public void Enable(object index) {
        }


        /// <summary>
        /// Load the panel content of a remote tab (specified by index)
        /// </summary>
        public void Load(object index) {
        }

    }
}
