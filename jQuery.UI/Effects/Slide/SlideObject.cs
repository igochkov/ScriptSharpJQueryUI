// SlideObject.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;
using jQueryApi.UI.Utilities;

namespace jQueryApi.UI.Effects {

    /// <summary>
    /// Slides the element out of the viewport.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <example>
    /// Hides the element by sliding it down.
    /// <code>
    /// $("div").click(function () {      $(this).hide("slide", { direction: "down" }, 1000);});
    /// </code>
    /// <code>
    /// <div></div>
    /// </code>
    /// </example>
    [Imported]
    [IgnoreNamespace]
    
    public class SlideObject : EffectObject {

        public SlideObject() {
        }

        [ScriptName("slide")]
        public SlideObject Slide() {
            return null;
        }

        [ScriptName("slide")]
        public SlideObject Slide(SlideOptions options) {
            return null;
        }
    }
}
