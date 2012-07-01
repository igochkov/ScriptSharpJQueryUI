// ColorizeOptions.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Widget
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Runtime.CompilerServices;
using jQueryApi.UI.Utilities;

namespace Sample.Widget {
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public sealed class ColorizeOptions : WidgetOptions {

        public ColorizeOptions() {
        }

        public ColorizeOptions(params object[] nameValuePairs) {
        }

        [IntrinsicProperty]
        public int Red {
            get {
                return 0;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public int Green {
            get {
                return 0;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public int Blue {
            get {
                return 0;
            }
            set {
            }
        }
    }
}
