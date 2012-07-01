// ResizeHelper.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Resizable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Interactions;

namespace Sample.Resizable
{
    internal static class ResizeHelper
    {
        static ResizeHelper()
        {
           jQuery.OnDocumentReady(delegate()
           {
               jQuery.Select("#resizable10")
                   .Plugin<ResizableObject>()
                   .Resizable(new ResizableOptions(ResizableOption.Helper, "ui-resizable-helper"));
           });
        }
    }
}
