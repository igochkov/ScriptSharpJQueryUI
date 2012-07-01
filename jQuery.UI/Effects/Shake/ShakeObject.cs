// ShakeObject.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;
using jQueryApi.UI.Utilities;

namespace jQueryApi.UI.Effects {

    /// <summary>
    /// Shakes the element multiple times, vertically or horizontally.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <example>
    /// Shakes 3 times when clicking on the element.
    /// <code>
    /// $("div").click(function () {      $(this).effect("shake", { times:3 }, 300);});
    /// </code>
    /// <code>
    /// <div></div>
    /// </code>
    /// </example>
    [Imported]
    [IgnoreNamespace]
    
    public class ShakeObject : EffectObject {

        public ShakeObject() {
        }

        [ScriptName("shake")]
        public ShakeObject Shake() {
            return null;
        }

        [ScriptName("shake")]
        public ShakeObject Shake(ShakeOptions options) {
            return null;
        }
    }
}
