// EmptyLists.cs
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
    internal static class EmptyLists
    {
        static EmptyLists()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("ul.droptrue" )
                      .Plugin<SortableObject>()
                      .Sortable(new SortableOptions(SortableOption.ConnectWith, "ul"));

		        jQuery.Select("ul.dropfalse" )
                      .Plugin<SortableObject>()
                      .Sortable(new SortableOptions(SortableOption.ConnectWith, "ul",
                                                    SortableOption.DropOnEmpty, false));
            });
        }
    }
}
