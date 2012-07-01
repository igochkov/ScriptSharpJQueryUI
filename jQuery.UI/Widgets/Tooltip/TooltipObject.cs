// TooltipObject.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;
using jQueryApi.UI.Utilities;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Customizable, themeable tooltips, replacing native tooltips.
    /// </summary>
    /// <remarks>
    /// <para>Tooltip replaces native tooltips, making them themable as well as  allowing various customizations:</para><ul><li>display other content than just the title, like inline footnotes or extra content retrieved via Ajax</li><li>customize the positioning, eg. to center the tooltip above elements</li><li>add extra classes to customize the appearance, for warning or error fields</li></ul><para>A fade animation is used by default to show and hide the tooltip, making the appearance a bit more organic, compared to just toggling the visiblity. This can be customized with the <code>show</code> and <code>hide</code> options.</para><para>The <code>title</code> and <code>content</code> options need to stay in-sync. If you change one of them, you need to change the other.</para><para>This widget requires some functional CSS, otherwise it won't work. If you build a custom theme, use the widget's specific CSS file as a starting point.</para>
    /// </remarks>
    /// <example>
    /// 
    /// <code>
    /// 
    /// </code>
    /// <code>
    /// 
    /// </code>
    /// </example>
    [Imported]
    [IgnoreNamespace]
    
    public class TooltipObject : WidgetObject {

        public TooltipObject() {
        }

        [ScriptName("tooltip")]
        public TooltipObject Tooltip() {
            return null;
        }

        [ScriptName("tooltip")]
        public TooltipObject Tooltip(TooltipOptions options) {
            return null;
        }

        [ScriptName("tooltip")]
        public object Tooltip(TooltipMethod method, params object[] options) {
            return null;
        }

        /// <summary>
        /// Programmatically close a tooltip. Sames rules as for <code>open</code> method.
        /// </summary>
        public void Close(jQueryEvent @event) {
        }


        /// <summary>
        /// Programmatically open a tooltip. If the widget's element is the target, the event argument is optional. Otherwise you have to pass an event object with the <code>currentTarget</code> property pointing at the target.
        /// </summary>
        public void Open(jQueryEvent @event) {
        }

    }
}
