// Default.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Resizable
// Copyright (c) Ivaylo Gochkov, 2012
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using jQueryApi;
using jQueryApi.UI;

namespace Sample.Resizable
{
    internal static class Default
    {
        static Default()
        {
           jQuery.OnDocumentReady(delegate()
           {
               jQuery.Select("#resizable1")
                   .Plugin<ResizableObject>()
                   .Resizable();
           });
        }
    }
}
