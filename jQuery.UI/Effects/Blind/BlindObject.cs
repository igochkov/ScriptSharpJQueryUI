// BlindObject.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;
using jQueryApi.UI.Utilities;

namespace jQueryApi.UI.Effects {

    /// <summary>
    /// The blind effect hides or shows an element by wrapping the element in a container, and "pulling the blinds"
    /// </summary>
    /// <remarks>
    /// The container has <code>overflow:hidden</code> applied, so height changes affect what's visible.
    /// </remarks>
    /// <example>
    /// 
    /// </example>
    [Imported]
    [IgnoreNamespace]
    
    public class BlindObject : EffectObject {

        public BlindObject() {
        }

        [ScriptName("blind")]
        public BlindObject Blind() {
            return null;
        }

        [ScriptName("blind")]
        public BlindObject Blind(BlindOptions options) {
            return null;
        }
    }
}
