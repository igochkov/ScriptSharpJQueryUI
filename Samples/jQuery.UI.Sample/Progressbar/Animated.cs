// Animated.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Progressbar
// Copyright (c) Ivaylo Gochkov, 2012
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using jQueryApi;
using jQueryApi.UI;

namespace Sample.Progressbar
{
    internal static class Animated
    {
        static Animated()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#progressbar2")
                    .Plugin<ProgressbarObject>()
                    .Progressbar(new ProgressbarOptions(ProgressbarOption.Value, 59));
            });
        }
    }
}
