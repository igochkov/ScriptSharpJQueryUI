// RemoteDatasource.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Autocomplete
// Copyright (c) Ivaylo Gochkov, 2012
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System.Runtime.CompilerServices;
using jQueryApi;
using jQueryApi.UI;

namespace Sample.Autocomplete {
    internal static class RemoteDatasource {
        static RemoteDatasource() {
            jQuery.OnDocumentReady(delegate() {
                jQuery.Select("#birds")
                    .Plugin<AutocompleteObject>()
                    .Autocomplete(new AutocompleteOptions(
                        AutocompleteOption.Source, "Search",
                        AutocompleteOption.MinLength, 2,
                        AutocompleteEvent.Select, new AutocompleteSelectEventHandler(delegate(jQueryEvent e, AutocompleteSelectEvent ui) {
                            Log(ui.Item != null
                               ? "Selected: " + ((AutocompleteData)ui.Item).Value + " aka " + ((AutocompleteData)ui.Item).Id
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
    public class AutocompleteData {
        [IntrinsicProperty]
        public string Value { get { return string.Empty; } set { } }
        [IntrinsicProperty]
        public string Id { get { return string.Empty; } set { } }
    }
}
