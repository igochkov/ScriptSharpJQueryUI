// Default.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/ProgressBar
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.ProgressBar
{
    internal static class Default
    {
        static Default()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#progressbar1")
                    .Plugin<ProgressBarObject>()
                    .ProgressBar(new ProgressBarOptions(ProgressBarOption.Value, 37));
            });
        }
    }
}
