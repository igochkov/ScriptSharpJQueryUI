// Cookie.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Tabs
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.Tabs
{
    internal static class Cookie
    {
        static Cookie()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#tabs8")
                    .Plugin<TabsObject>()
                    .Tabs(new TabsOptions("cookie", new TabsOptions("expires", 1)));
            });
        }
    }
}
