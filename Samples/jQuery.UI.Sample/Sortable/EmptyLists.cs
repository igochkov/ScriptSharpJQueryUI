// EmptyLists.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Sortable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Interactions;

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
