// Revert.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Droppable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI;
using jQueryApi.UI.Interactions;

namespace Sample.Droppable
{
    internal static class Revert
    {
        static Revert()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#draggableRevert10")
                    .Plugin<DraggableObject>()
                    .Draggable(new DraggableOptions(DraggableOption.Revert, "valid"));

                jQuery.Select("#draggableRevert20")
                    .Plugin<DraggableObject>()
                    .Draggable(new DraggableOptions(DraggableOption.Revert, "invalid"));

                jQuery.Select("#droppableRevert10")
                    .Plugin<DroppableObject>()
                    .Droppable(new DroppableOptions(DroppableOption.ActiveClass, "ui-state-hover"
                                                   , DroppableOption.HoverClass, "ui-state-active"
                        , DroppableEvents.Drop
                        , new jQueryUIEventHandler<DropEvent>(delegate(jQueryEvent e, DropEvent ui) 
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
