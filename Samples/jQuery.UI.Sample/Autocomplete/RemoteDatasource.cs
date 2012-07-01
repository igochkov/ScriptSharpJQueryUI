// RemoteDatasource.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/AutoComplete
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Runtime.CompilerServices;
using jQueryApi;
using jQueryApi.UI;
using jQueryApi.UI.Widgets;

namespace Sample.AutoComplete {
    internal static class RemoteDatasource {
        static RemoteDatasource() {
            jQuery.OnDocumentReady(delegate() {

                AutoCompleteOptions options = new AutoCompleteOptions();
                options.Source = "Search";
                options.MinLength = 2;
                options.Select = new jQueryUIEventHandler<AutoCompleteSelectEvent>(delegate(jQueryEvent e, AutoCompleteSelectEvent ui) {
                    Log(ui.Item != null
                       ? "Selected: " + ((AutoCompleteData)ui.Item).Value + " aka " + ((AutoCompleteData)ui.Item).Id
                       : "Nothing selected, input was " + jQuery.This.GetValue());
                });


                jQuery.Select("#birds")
                      .Plugin<AutoCompleteObject>()
                      .AutoComplete(options);
            });


        }

        static void Log(string message) {
            jQuery.Select("<div/>").Text(message).PrependTo("#log");
            jQuery.Select("#log").ScrollTop(0);
        }
    }

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class AutoCompleteData {
        [IntrinsicProperty]
        public string Value { get { return string.Empty; } set { } }
        [IntrinsicProperty]
        public string Id { get { return string.Empty; } set { } }
    }
}
