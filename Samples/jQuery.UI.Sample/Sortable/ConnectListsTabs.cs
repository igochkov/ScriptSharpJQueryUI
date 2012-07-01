// ConnectLists.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Sortable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI;
using jQueryApi.UI.Interactions;
using jQueryApi.UI.Widgets;

namespace Sample.Sortable
{
    internal static class ConnectListsTabs
    {
        static ConnectListsTabs()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#sortable41, #sortable42")
                      .Plugin<SortableObject>()
                      .Sortable();

                TabsObject tabs = jQuery.Select("#tabs")
                                        .Plugin<TabsObject>()
                                        .Tabs();

                DroppableObject tabItems
                    = jQuery.Select("ul:first li", tabs)
                            .Plugin<DroppableObject>()
                            .Droppable(new DroppableOptions(
                                DroppableOption.Accept, ".connectedSortable2 li",
                                DroppableOption.HoverClass, "ui-state-hover",
                                DroppableEvents.Drop, new jQueryUIEventHandler<DropEvent>(delegate(jQueryEvent e, DropEvent dropEvent) {
                                    jQueryObject list = jQuery.Select(jQuery.This.Find("a").GetAttribute("href"))
                                                              .Find(".connectedSortable2");

                                    ((jQueryObject)dropEvent.Draggable).Hide(EffectDuration.Slow, delegate() {
                                        tabs.Tabs(new TabsOptions(TabsOption.Active, jQuery.This.Index(jQuery.This.Selector)));
                                        jQuery.This.AppendTo(list).Show(EffectDuration.Slow);                
                                    });
                                })));
            });
        }
    }
}
