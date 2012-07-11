// FillSpace.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Accordion
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using jQueryApi;
using jQueryApi.UI.Interactions;
using jQueryApi.UI.Widgets;

namespace Sample.Accordion {
    internal static class FillSpace {
        static FillSpace() {
            jQuery.OnDocumentReady(delegate() {
                jQuery.Select("#accordion2")
                    .Plugin<AccordionObject>()
                    .Accordion(new AccordionOptions("fillSpace", true));

                jQuery.Select("#accordionResizer")
                   .Plugin<ResizableObject>()
                   .Resizable(new ResizableOptions(
                        ResizableOption.MinHeight, 140,
                        ResizableEvents.Resize, new Action(delegate() {
                            jQuery.Select("#accordion2")
                                .Plugin<AccordionObject>()
                                .Accordion(AccordionMethod.Resize);
                        })
                   ));
            });
        }
    }
}
