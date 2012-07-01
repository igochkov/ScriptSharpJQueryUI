// PuffObject.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;
using jQueryApi.UI.Utilities;

namespace jQueryApi.UI.Effects {

    /// <summary>
    /// Creates a puff effect by scaling the element up and hiding it at the same time.
    /// </summary>
    /// <remarks>
    /// This is the only effect without a separate file, it shares a file with the scale effect.
    /// </remarks>
    /// <example>
    /// Puff the element away.
    /// <code>
    /// $("div").click(function () {      $(this).hide("puff", {}, 1000);});
    /// </code>
    /// <code>
    /// <div></div>
    /// </code>
    /// </example>
    [Imported]
    [IgnoreNamespace]
    
    public class PuffObject : EffectObject {

        public PuffObject() {
        }

        [ScriptName("puff")]
        public PuffObject Puff() {
            return null;
        }

        [ScriptName("puff")]
        public PuffObject Puff(PuffOptions options) {
            return null;
        }
    }
}
