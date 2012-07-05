// Default.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Button
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.Button {
    internal static class Default {
        static Default() {
            jQuery.OnDocumentReady(delegate() {
                jQueryObject demo = jQuery.Select(".demo");

                jQuery.Select("#button1, #button2, #button3", demo)
                    .Plugin<ButtonObject>()
                    .Button();

                jQuery.Select("#button3", demo)
                    .Click(new jQueryEventHandler(delegate(jQueryEvent e) {
                        e.PreventDefault();
                        e.StopPropagation();
                }));
            });
        }
    }
}
