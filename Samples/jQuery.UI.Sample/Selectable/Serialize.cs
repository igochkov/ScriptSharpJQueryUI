// Serialize.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Selectable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Html;
using jQueryApi;
using jQueryApi.UI;
using jQueryApi.UI.Interactions;

namespace Sample.Selectable
{
    internal static class Serialize
    {
        static Serialize()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#selectable2")
                      .Plugin<SelectableObject>()
                      .Selectable(new SelectableOptions(SelectableEvents.Stop,
                new jQueryUIEventHandler<jQueryObject>(delegate(jQueryEvent e, jQueryObject uiEvent)
                {
                    jQueryObject result = jQuery.Select("#select-result").Empty();

                    jQuery.Select(".ui-selected", jQuery.Select("#selectable2")).Each(delegate(int idx, Element element)
                    {
                        int index = jQuery.Select("#selectable2 li").Index(element);
                        result.Append(" #" + (index + 1));
                    });
                })));
            });
        }
    }
}
