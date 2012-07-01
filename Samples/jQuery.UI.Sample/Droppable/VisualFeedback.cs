// VisualFeedback.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Droppable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI;
using jQueryApi.UI.Interactions;

namespace Sample.Droppable
{
    internal static class VisualFeedback
    {
        static VisualFeedback()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#draggableVisualFeedback1, #draggableVisualFeedback2")
                    .Plugin<DraggableObject>()
                    .Draggable();

                jQueryUIEventHandler<DropEvent> drop
                    = new jQueryUIEventHandler<DropEvent>(delegate(jQueryEvent e, DropEvent ui) 
                    {
                        jQuery.This
                                .AddClass("ui-state-highlight")
                                .Find("p")
                                .Html("Dropped!");
                    });

                jQuery.Select("#droppableVisualFeedback1")
                    .Plugin<DroppableObject>()
                    .Droppable(new DroppableOptions(DroppableOption.HoverClass, "ui-state-active"
                                                   , DroppableEvents.Drop, drop));

                jQuery.Select("#droppableVisualFeedback2")
                    .Plugin<DroppableObject>()
                    .Droppable(new DroppableOptions(DroppableOption.Accept, "#draggableVisualFeedback2"
                                                   , DroppableOption.ActiveClass, "ui-state-hover"
                                                   , DroppableEvents.Drop, drop));
            });
        }
    }
}
