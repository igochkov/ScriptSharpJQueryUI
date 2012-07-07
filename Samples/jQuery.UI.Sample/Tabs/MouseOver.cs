// MouseOver.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Tabs
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.Tabs
{
    internal static class MouseOver
    {
        static MouseOver()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#tabs3")
                    .Plugin<TabsObject>()
                    .Tabs(new TabsOptions(TabsOption.Event, "mouseover"));
            });
        }
    }
}
