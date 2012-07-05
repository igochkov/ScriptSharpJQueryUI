// Icons.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Button
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.Button {
    internal static class Icons {
        static Icons() {
            jQuery.OnDocumentReady(delegate() {
                jQuery.Select("#button6")
                    .Plugin<ButtonObject>()
                    .Button(new ButtonOptions(ButtonOption.Icons, new ButtonOptions("primary", "ui-icon-locked"),
                                              ButtonOption.Text, false));

                jQuery.Select("#button7")
                    .Plugin<ButtonObject>()
                    .Button(new ButtonOptions(ButtonOption.Icons, new ButtonOptions("primary", "ui-icon-locked")));

                jQuery.Select("#button8")
                    .Plugin<ButtonObject>()
                    .Button(new ButtonOptions(ButtonOption.Icons, new ButtonOptions("primary", "ui-icon-gear",
                                                                                    "secondary", "ui-icon-triangle-1-s")));

                jQuery.Select("#button9")
                    .Plugin<ButtonObject>()
                    .Button(new ButtonOptions(ButtonOption.Icons, new ButtonOptions("primary", "ui-icon-gear",
                                                                                    "secondary", "ui-icon-triangle-1-s"),
                                              ButtonOption.Text, false));
            });
        }
    }
}
