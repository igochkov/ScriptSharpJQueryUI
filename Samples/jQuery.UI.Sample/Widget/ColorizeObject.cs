// ColorizeObject.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Widget
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;
using jQueryApi.UI.Utilities;
using jQueryApi.UI.Widgets;

namespace Sample.Widget {
    [Imported]
    [IgnoreNamespace]
    public class ColorizeObject : WidgetObject {

        private ColorizeObject() {
        }

        [ScriptName("colorize")]
        public ColorizeObject Colorize() {
            return null;
        }

        [ScriptName("colorize")]
        public ColorizeObject Colorize(ColorizeOptions options) {
            return null;
        }

        [ScriptName("colorize")]
        public object Colorize(ColorizeMethod method, params object[] options) {
            return null;
        }

        [ScriptName("_refresh")]
        public void Refresh() {

        }

        [IntrinsicProperty]
        public Function Random {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public ButtonObject Changer {
            get {
                return null;
            }
            set {
            }
        }
    }
}
