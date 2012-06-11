// DisplayAsGrid.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Selectable
// Copyright (c) Ivaylo Gochkov, 2012
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using jQueryApi;
using jQueryApi.UI;

namespace Sample.Selectable
{
    internal static class DisplayAsGrid
    {
        static DisplayAsGrid()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#selectable3")
                    .Plugin<SelectableObject>()
                    .Selectable();
            });
        }
    }
}
