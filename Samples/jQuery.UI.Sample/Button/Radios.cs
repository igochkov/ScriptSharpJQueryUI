// Radios.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Button
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.Button {
    internal static class Radios {
        static Radios() {
            jQuery.OnDocumentReady(delegate() {
                jQuery.Select("#button4")
                    .Plugin<ButtonSetObject>()
                    .ButtonSet();
            });
        }
    }
}
