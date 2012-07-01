// AutoScroll.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Draggable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Interactions;

namespace Sample.Draggable
{
    internal static class AutoScroll
    {
        static AutoScroll()
        {
            jQuery.OnDocumentReady(delegate()
            {
                DraggableOptions options;

                options = new DraggableOptions();
                options.Scroll = true;

                jQuery.Select("#draggableAutoScroll1")
                      .Plugin<DraggableObject>()
                      .Draggable(options);

                options = new DraggableOptions();
                options.Scroll = true;
                options.ScrollSensitivity = 100;
                
                jQuery.Select("#draggableAutoScroll2")
                      .Plugin<DraggableObject>()
                      .Draggable(options);

                options = new DraggableOptions();
                options.Snap = true;
                options.ScrollSpeed = 100;

                jQuery.Select("#draggableAutoScroll3")
                      .Plugin<DraggableObject>()
                      .Draggable(options);
            });
        }
    }
}
