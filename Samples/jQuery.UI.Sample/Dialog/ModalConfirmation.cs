// ModalConfirmation.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Button
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.Dialog {
    internal static class ModalConfirmation {
        static ModalConfirmation() {
            jQuery.OnDocumentReady(delegate() {
                jQuery.Select("#dialog-confirm")
                    .Plugin<DialogObject>()
                    .Dialog(new DialogOptions(DialogOption.Resizable, false,
                                              DialogOption.Height, 200,
                                              DialogOption.Width, 500,
                                              DialogOption.Modal, true,
                                              DialogOption.Buttons, new DialogOptions( 
                                                "Delete all items", new Action(delegate() {
                                                    jQuery.This.Plugin<DialogObject>()
                                                               .Dialog(DialogMethod.Close);
                                                }),
                                                "Cancel", new Action(delegate() {
                                                    jQuery.This.Plugin<DialogObject>()
                                                               .Dialog(DialogMethod.Close);
                                                }))));
            });
        }
    }
}