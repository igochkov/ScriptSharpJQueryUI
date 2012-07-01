// ConnectLists.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Sortable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Interactions;

namespace Sample.Sortable
{
    internal static class ConnectLists
    {
        static ConnectLists()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#sortable31, #sortable32")
                    .Plugin<SortableObject>()
                    .Sortable(new SortableOptions(SortableOption.ConnectWith, ".connectedSortable"));
            });
        }
    }
}
