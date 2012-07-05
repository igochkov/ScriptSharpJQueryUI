// SplitButton.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Button
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.Button {
    internal static class SplitButton {
        static SplitButton() {
            jQuery.OnDocumentReady(delegate() {
                jQuery.Select("#rerun")
                    .Plugin<ButtonObject>()
                    .Button()
                    .Click(new jQueryEventHandler(delegate(jQueryEvent e) {
                        Script.Alert("Running the last action");
                    }));

                jQuery.Select("#select")
                    .Plugin<ButtonObject>()
                    .Button(new ButtonOptions(ButtonOption.Text, false,
                                              ButtonOption.Icons, new ButtonOptions("primary", "ui-icon-triangle-1-s")))
                    .Click(new jQueryEventHandler(delegate(jQueryEvent e) {
                        Script.Alert("Could display a menu to select an action");
                    }))
                    .Parent()
                    .Plugin<ButtonSetObject>()
                    .ButtonSet();
            });
        }
    }
}
