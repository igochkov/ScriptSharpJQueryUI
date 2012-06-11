// DropPlaceholder.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Sortable
// Copyright (c) Ivaylo Gochkov, 2012
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using jQueryApi;
using jQueryApi.UI;

namespace Sample.Sortable
{
    internal static class DropPlaceholder
    {
        static DropPlaceholder()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#sortable2")
                    .Plugin<SortableObject>()
                    .Sortable(new SortableOptions(SortableOption.Placeholder, "ui-state-highlight"));
            });
        }
    }
}
