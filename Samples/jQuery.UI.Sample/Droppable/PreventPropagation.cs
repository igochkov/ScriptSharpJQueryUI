// PreventPropagation.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Droppable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI;
using jQueryApi.UI.Interactions;

namespace Sample.Droppable
{
    internal static class PreventPropagation
    {
        static PreventPropagation()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#draggablePreventPropagation")
                    .Plugin<DraggableObject>()
                    .Draggable();

                jQueryUIEventHandler<DropEvent> drop
                    = new jQueryUIEventHandler<DropEvent>(delegate(jQueryEvent e, DropEvent ui)
                    {
                        jQuery.This
                                .AddClass("ui-state-highlight")
                                .Find("> p")
                                .Html("Dropped!");
                    });

                jQuery.Select("#droppablePreventPropagation1, #droppablePreventPropagation1-inner")
                    .Plugin<DroppableObject>()
                    .Droppable(new DroppableOptions(DroppableOption.ActiveClass, "ui-state-hover"
                                                   , DroppableOption.HoverClass, "ui-state-active"
                                                   , DroppableEvents.Drop, drop));

                jQuery.Select("#droppablePreventPropagation2, #droppablePreventPropagation2-inner")
                    .Plugin<DroppableObject>()
                    .Droppable(new DroppableOptions(DroppableOption.ActiveClass, "ui-state-hover"
                                                   , DroppableOption.HoverClass, "ui-state-active"
                                                   , DroppableOption.Greedy, true
                                                   , DroppableEvents.Drop, drop));
            });
        }
    }
}
