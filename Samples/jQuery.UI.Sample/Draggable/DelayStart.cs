// DelayStart.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Draggable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Interactions;
using jQueryApi.UI.Utilities;

namespace Sample.Draggable
{
    internal static class DelayStart
    {
        static DelayStart()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#draggableDelay")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions(DraggableOption.Distance, 20));

                jQuery.Select("#draggableDelay2")
                              .Plugin<DraggableObject>()
                              .Draggable(new DraggableOptions(DraggableOption.Delay, 1000));

                jQuery.Select(".ui-draggable")
                      .Plugin<jQueryUIObject>()
                      .DisableSelection();
            });
        }
    }
}
