// ModalDialog.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Button
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.Dialog {
    internal static class ModalDialog {
        static ModalDialog() {
            jQuery.OnDocumentReady(delegate() {
                jQuery.Select("#dialog-modal")
                    .Plugin<DialogObject>()
                    .Dialog(new DialogOptions(DialogOption.Height, 140,
                                              DialogOption.Modal, true));
            });
        }
    }
}
