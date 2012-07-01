// ShoppingCart.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Droppable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using jQueryApi;
using jQueryApi.UI;
using jQueryApi.UI.Interactions;
using jQueryApi.UI.Widgets;

namespace Sample.Droppable
{
    internal static class ShoppingCart
    {
        static ShoppingCart()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#catalog")
                      .Plugin<AccordionObject>()
                      .Accordion();

                jQuery.Select("#catalog li")
                    .Plugin<DraggableObject>()
                    .Draggable(new DraggableOptions(DraggableOption.AppendTo, "body"
                                                   , DraggableOption.Helper, "clone"));

                jQuery.Select("#cart ol")
                    .Plugin<DroppableObject>()
                    .Droppable(new DroppableOptions(DroppableOption.ActiveClass, "ui-state-default"
                        , DroppableOption.HoverClass, "ui-state-hover"
                        , DroppableOption.Accept, ":not(.ui-sortable-helper)"
                        , DroppableEvents.Drop
                        , new jQueryUIEventHandler<DropEvent>(delegate(jQueryEvent e, DropEvent ui)
                        {
                            jQuery.This.Find(".placeholder").Remove();
                            jQuery.FromHtml("<li></li>").Text(ui.Draggable.GetText()).AppendTo(jQuery.This);
                        })))
                    .Plugin<SortableObject>()
                    .Sortable(new SortableOptions(SortableOption.Items, "li:not(.placeholder)"
                        , SortableEvents.Sort
                        , new Action(delegate()
                        {
                            // gets added unintentionally by droppable interacting with sortable
                            // using connectWithSortable fixes this, but doesn't allow you to customize active/hoverClass options
                            jQuery.This.RemoveClass("ui-state-default");
                        })));
            });
        }
    }
}
