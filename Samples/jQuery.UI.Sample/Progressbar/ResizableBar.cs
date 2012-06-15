// ResizableBar.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/ProgressBar
// Copyright (c) Ivaylo Gochkov, 2012
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using jQueryApi;
using jQueryApi.UI;

namespace Sample.ProgressBar
{
    internal static class ResizableBar
    {
        static ResizableBar()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#progressbar3")
                    .Plugin<ProgressBarObject>()
                    .ProgressBar(new ProgressBarOptions(ProgressBarOption.Value, 37));

                 jQuery.Select("#progressbarWrapper")
                    .Plugin<ResizableObject>()
                    .Resizable();
            });
        }
    }
}
