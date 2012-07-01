// IncludeExclude.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Sortable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Interactions;

namespace Sample.Sortable
{
    internal static class IncludeExclude
    {
        static IncludeExclude()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#sortable61" )
                      .Plugin<SortableObject>()
                      .Sortable(new SortableOptions(SortableOption.Items, "li:not(.ui-state-disabled)"));

                jQuery.Select("#sortable62")
                      .Plugin<SortableObject>()
                      .Sortable(new SortableOptions(SortableOption.Cancel, ".ui-state-disabled"));
            });
        }
    }
}
