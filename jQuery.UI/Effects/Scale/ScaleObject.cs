// ScaleObject.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;
using jQueryApi.UI.Utilities;

namespace jQueryApi.UI.Effects {

    /// <summary>
    /// Shrink or grow an element by a percentage factor.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <example>
    /// Scale the element to 0%, with the hide method (center vanishing point).
    /// <code>
    /// $("div").click(function () {    $(this).hide("scale", {}, 1000);});
    /// </code>
    /// <code>
    /// <div></div>
    /// </code>
    /// </example>
    [Imported]
    [IgnoreNamespace]
    
    public class ScaleObject : EffectObject {

        public ScaleObject() {
        }

        [ScriptName("scale")]
        public ScaleObject Scale() {
            return null;
        }

        [ScriptName("scale")]
        public ScaleObject Scale(ScaleOptions options) {
            return null;
        }
    }
}
