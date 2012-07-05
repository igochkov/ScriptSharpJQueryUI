// ToolBar.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Button
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.Button {
    internal static class ToolBar {
        static ToolBar() {
            jQuery.OnDocumentReady(delegate() {
                jQuery.Select("#beginning")
                    .Plugin<ButtonObject>()
                    .Button(new ButtonOptions(ButtonOption.Text, false,
                                              ButtonOption.Icons, new ButtonOptions("primary", "ui-icon-seek-start")));

                jQuery.Select("#rewind")
                    .Plugin<ButtonObject>()
                    .Button(new ButtonOptions(ButtonOption.Text, false,
                                              ButtonOption.Icons, new ButtonOptions("primary", "ui-icon-seek-prev")));

                jQuery.Select("#play")
                    .Plugin<ButtonObject>()
                    .Button(new ButtonOptions(ButtonOption.Text, false,
                                              ButtonOption.Icons, new ButtonOptions("primary", "ui-icon-play")))
                    .Click(new jQueryEventHandler(delegate(jQueryEvent e) {
                    ButtonOptions options;

                    if (jQuery.This.GetText() == "play") {
                        options = new ButtonOptions(ButtonOption.Label, "pause",
                                                    ButtonOption.Icons, new ButtonOptions("primary", "ui-icon-pause"));
                    } else {
                        options = new ButtonOptions(ButtonOption.Label, "play",
                                                    ButtonOption.Icons, new ButtonOptions("primary", "ui-icon-play"));
                    }
                    jQuery.This
                          .Plugin<ButtonObject>()
                          .Button(ButtonMethod.Option, options);
                }));

                jQuery.Select("#stop")
                  .Plugin<ButtonObject>()
                  .Button(new ButtonOptions(ButtonOption.Text, false,
                                            ButtonOption.Icons, new ButtonOptions("primary", "ui-icon-stop")))
                  .Click(new jQueryEventHandler(delegate(jQueryEvent e) {
                      jQuery.Select("#play")
                          .Plugin<ButtonObject>()
                          .Button(ButtonMethod.Option, new ButtonOptions(ButtonOption.Label, "play",
                                                                         ButtonOption.Icons, new ButtonOptions("primary", "ui-icon-play")));
                  }));

                jQuery.Select("#forward")
                    .Plugin<ButtonObject>()
                    .Button(new ButtonOptions(ButtonOption.Text, false,
                                              ButtonOption.Icons, new ButtonOptions("primary", "ui-icon-seek-nex")));

                jQuery.Select("#end")
                    .Plugin<ButtonObject>()
                    .Button(new ButtonOptions(ButtonOption.Text, false,
                                              ButtonOption.Icons, new ButtonOptions("primary", "ui-icon-seek-end")));

                jQuery.Select("#shuffle")
                    .Plugin<ButtonObject>()
                    .Button();

                jQuery.Select("#repeat")
                    .Plugin<ButtonSetObject>()
                    .ButtonSet();
            });
        }
    }
}
