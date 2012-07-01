// SizeObject.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;
using jQueryApi.UI.Utilities;

namespace jQueryApi.UI.Effects {

    /// <summary>
    /// Resize an element to a specified width and height.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <example>
    /// Size an element to 200 x 60.
    /// <code>
    /// $("div").click(function () {      $(this).effect("size", { to: {width: 200,height: 60} }, 1000);});
    /// </code>
    /// <code>
    /// <div></div>
    /// </code>
    /// </example>
    [Imported]
    [IgnoreNamespace]
    
    public class SizeObject : EffectObject {

        public SizeObject() {
        }

        [ScriptName("size")]
        public new SizeObject Size() {
            return null;
        }

        [ScriptName("size")]
        public SizeObject Size(SizeOptions options) {
            return null;
        }
    }
}
