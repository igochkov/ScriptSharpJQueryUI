// ModalMessage.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Button
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.Dialog {
    internal static class ModalMessage {
        static ModalMessage() {
            jQuery.OnDocumentReady(delegate() {
                jQuery.Select("#dialog-message")
                    .Plugin<DialogObject>()
                    .Dialog(new DialogOptions(DialogOption.Modal, true,
                                              DialogOption.Buttons, new DialogOptions( 
                                                "Ok", new Action(delegate() {
                                                    jQuery.This.Plugin<DialogObject>()
                                                               .Dialog(DialogMethod.Close);
                                                }))));
            });
        }
    }
}
