// DragHandle.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Draggable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI;
using jQueryApi.UI.Interactions;

namespace Sample.Draggable
{
    internal static class DragHandle
    {
        static DragHandle()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#draggableHandle1")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions(DraggableOption.Handle, "p"));

                jQuery.Select("#draggableHandle2")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions(DraggableOption.Cancel, "p.ui-widget-header"));

                jQuery.Select("div, p")
                      .Plugin<jQueryUIObject>()
                      .DisableSelection();
            });
        }
    }
}
