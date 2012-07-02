// Icons.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Accordion
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.Accordion
{
    internal static class Icons {
        static Icons() {
            jQuery.OnDocumentReady(delegate() {
                AccordionOptions icons 
                    = new AccordionOptions("header", "ui-icon-circle-arrow-e",
                                           "headerSelected", "ui-icon-circle-arrow-s");

                jQuery.Select("#accordion7")
                    .Plugin<AccordionObject>()
                    .Accordion(new AccordionOptions(AccordionOption.Icons, icons));

                jQuery.Select("#toggle")
                      .Plugin<ButtonObject>()
                      .Button();
                //      .Toggle(new jQueryEventHandler(delegate(jQueryEvent @event) {
                //          jQuery.Select("#accordion7")
                //                .Plugin<AccordionObject>()
                //                .Accordion(new AccordionOptions(AccordionMethod.Option, AccordionOption.Icons, false));
                //      }),
                //      new jQueryEventHandler(delegate(jQueryEvent @event) {
                //          jQuery.Select("#accordion7")
                //              .Plugin<AccordionObject>()
                //              .Accordion(new AccordionOptions(AccordionMethod.Option, AccordionOption.Icons, icons));
                //}));
            });
        }
    }
}
