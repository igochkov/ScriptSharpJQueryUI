// RemoteDatasource.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/AutoComplete
// Copyright (c) Ivaylo Gochkov, 2012
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System.Runtime.CompilerServices;
using jQueryApi;
using jQueryApi.UI;

namespace Sample.AutoComplete {
    internal static class RemoteDatasource {
        static RemoteDatasource() {
            jQuery.OnDocumentReady(delegate() {
                jQuery.Select("#birds")
                    .Plugin<AutoCompleteObject>()
                    .AutoComplete(new AutoCompleteOptions(
                        AutoCompleteOption.Source, "Search",
                        AutoCompleteOption.MinLength, 2,
                        AutoCompleteEvent.Select, new AutoCompleteSelectEventHandler(delegate(jQueryEvent e, AutoCompleteSelectEvent ui) {
                            Log(ui.Item != null
                               ? "Selected: " + ((AutoCompleteData)ui.Item).Value + " aka " + ((AutoCompleteData)ui.Item).Id
                               : "Nothing selected, input was " + jQuery.This.GetValue());
                })));
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
