// AnimatedDialog.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Button
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.Dialog {
    internal static class AnimatedDialog {
        static AnimatedDialog() {
            // increase the default animation speed to exaggerate the effect
	        //$.fx.speeds._default = 1000;

            jQuery.OnDocumentReady(delegate() {
                jQuery.Select("#dialog2")
                    .Plugin<DialogObject>()
                    .Dialog(new DialogOptions(DialogOption.AutoOpen, false,
                                              DialogOption.Show, "blind",
                                              DialogOption.Hide, "explode"));

                jQuery.Select("#opener")
                      .Click(new jQueryEventHandler(delegate(jQueryEvent e) {
                          jQuery.Select("#dialog2")
                                .Plugin<DialogObject>()
                                .Dialog(DialogMethod.Open);

                          e.PreventDefault();
                          e.StopPropagation();
                      }));
            });
        }
    }
}
