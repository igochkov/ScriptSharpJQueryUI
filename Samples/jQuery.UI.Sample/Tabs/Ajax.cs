// Ajax.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Tabs
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Html;
using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.Tabs {
    internal static class Ajax {
        static Ajax() {
            jQuery.OnDocumentReady(delegate() {
                jQuery.Select("#tabs2")
                    .Plugin<TabsObject>()
                    .Tabs(new TabsOptions("ajaxOptions",
                          // HACK: use AjaxOptions instead of TabsOptions. Currently the AjaxErrorCallback doesn't have anchor parameter
                          new TabsOptions("error", new Action<jQueryXmlHttpRequest, string, int, Location>(
                              // HACK: use AnchorObject instead of Location. Currently doen's have Hash property.
                              delegate(jQueryXmlHttpRequest xhr, string status, int index, Location anchor) {
                                  jQuery.Select(anchor.Hash).Html(
                                      "Couldn't load this tab. We'll try to fix this as soon as possible. " +
                                      "If this wouldn't be a demo.");
                              }))));
            });
        }
    }
}
