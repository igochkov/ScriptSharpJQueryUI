// CursorStyle.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Draggable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Interactions;

namespace Sample.Draggable
{
    internal static class CursorStyle
    {
        static CursorStyle()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#draggableCursor1")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions(DraggableOption.Cursor, "move"
                                                     , "top", 56, "left", 56 ));

                jQuery.Select("#draggableCursor2")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions(DraggableOption.Cursor, "crosshair"
                                                     , "top", -5, "left", -5));

                jQuery.Select("#draggableCursor3")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions("bottom", 0));
            });
        }
    }
}
