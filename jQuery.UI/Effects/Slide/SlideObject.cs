// SlideObject.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {

    /// <summary>
    /// Slides the element out of the viewport.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public abstract class SlideObject : EffectObject {

        protected SlideObject() {
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
