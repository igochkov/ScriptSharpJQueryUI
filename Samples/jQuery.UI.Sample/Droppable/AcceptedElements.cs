// AcceptedElements.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Droppable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI;
using jQueryApi.UI.Interactions;

namespace Sample.Droppable
{
    internal static class AcceptedElements
    {
        static AcceptedElements()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#draggableAcceptedElements, #draggable-nonvalid")
                   .Plugin<DraggableObject>()
                   .Draggable();

                jQuery.Select("#droppableAcceptedElements")
                    .Plugin<DroppableObject>()
                    .Droppable(new DroppableOptions(DroppableOption.Accept, "#draggableAcceptedElements"
                                                   , DroppableOption.ActiveClass, "ui-state-hover"
                                                   , DroppableOption.HoverClass, "ui-state-active"
                                                   , DroppableEvents.Drop, new jQueryUIEventHandler<DropEvent>(delegate(jQueryEvent e, DropEvent ui)
                                                   {
                                                        jQuery.This
                                                              .AddClass("ui-state-highlight")
                                                              .Find("p")
                                                              .Html("Dropped!");
                                                   })));
            });
        }
    }
}
