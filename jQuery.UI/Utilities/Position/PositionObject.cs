// PositionObject.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;
using jQueryApi.UI.Utilities;

namespace jQueryApi.UI.Utilities {

    /// <summary>
    /// Place an element relative to another
    /// </summary>
    /// <remarks>
    /// <para>Utility script for positioning any widget relative to the window, document, a particular element, or the cursor/mouse.</para><para><em>Note: jQuery UI does not support positioning hidden elements.</em></para><para>This is a standalone jQuery plugin and has no dependencies on other jQuery UI components.</para><para>This plugin extends jQuery's built-in position getter method. If you forget to include this plugin, code calling position() won't fail directly, as the method still exists. But it'll just retrieve the position instead of setting it.</para>
    /// </remarks>
    /// <example>
    /// Clicking on the green element transfers to the other.
    /// <code>
    /// $("#position1").position({my: "center",at: "center",of: "#targetElement"});$("#position2").position({my: "left top",at: "left top",of: "#targetElement"});$("#position3").position({my: "right center",at: "right bottom",of: "#targetElement"});$(document).mousemove(function(ev){$("#position4").position({my: "left bottom",of: ev,offset: "3 -3",collision: "fit"});});
    /// </code>
    /// <code>
    /// <div id="targetElement"><div class="positionDiv" id="position1"></div><div class="positionDiv" id="position2"></div><div class="positionDiv" id="position3"></div><div class="positionDiv" id="position4"></div></div>
    /// </code>
    /// </example>
    [Imported]
    [IgnoreNamespace]
    
    public class PositionObject : jQueryUIObject {

        public PositionObject() {
        }

        [ScriptName("position")]
        public new PositionObject Position() {
            return null;
        }

        [ScriptName("position")]
        public PositionObject Position(PositionOptions options) {
            return null;
        }
    }
}
