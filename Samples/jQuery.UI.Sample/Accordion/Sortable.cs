// Sortable.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Accordion
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Runtime.CompilerServices;
using jQueryApi;
using jQueryApi.UI;
using jQueryApi.UI.Interactions;
using jQueryApi.UI.Widgets;

namespace Sample.Accordion
{
    internal static class Sortable {
        static Sortable() {
            jQuery.OnDocumentReady(delegate() {
                jQuery.Select("#accordion8")
                    .Plugin<AccordionObject>()
                    .Accordion(new AccordionOptions(
                        AccordionOption.Header, "> div > h3"
                     ))
                    .Plugin<SortableObject>()
                    .Sortable(new SortableOptions(
                        SortableOption.Axis, "y",
                        SortableOption.Handle, "h3",
                        SortableEvents.Stop, new jQueryUIEventHandler<StopEventData>(delegate(jQueryEvent @event, StopEventData ui) {
                            // IE doesn't register the blur when sorting
                            // so trigger focusout handlers to remove .ui-state-focus
                            ui.Item.Children("h3").TriggerHandler("focusout");
                        })
                    ));
            });
        }
    }

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class StopEventData {
        [IntrinsicProperty]
        public jQueryObject Item { get { return null; } set { } }
    }
}
