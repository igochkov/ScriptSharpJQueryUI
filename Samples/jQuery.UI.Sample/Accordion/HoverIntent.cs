// HoverIntent.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Accordion
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.Accordion
{
    internal static class HoverIntent
    {
        static HoverIntent()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#accordion4")
                                    .Plugin<AccordionObject>()
                                    .Accordion(new AccordionOptions(AccordionOption.Event, "click hoverintent"));

                // TODO:
            });
        }
    }
}
