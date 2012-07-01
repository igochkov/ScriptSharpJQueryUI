// DraggableSortable.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Draggable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Interactions;
using jQueryApi.UI.Utilities;

namespace Sample.Draggable
{
    internal static class DraggableSortable
    {
        static DraggableSortable()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#sortable")
                    .Plugin<SortableObject>()
                    .Sortable(new SortableOptions(SortableOption.Revert, true));

                jQuery.Select("#draggableSortable")
                    .Plugin<DraggableObject>()
                    .Draggable(new DraggableOptions( DraggableOption.ConnectToSortable, "#sortable"
                                                   , DraggableOption.Helper, "clone"
                                                   , DraggableOption.Revert, "invalid"));

                jQuery.Select("ul, li")
                      .Plugin<jQueryUIObject>()
                      .DisableSelection();
            });
        }
    }
}
