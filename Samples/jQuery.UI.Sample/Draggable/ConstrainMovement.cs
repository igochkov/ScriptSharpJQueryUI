// ConstrainMovement.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Draggable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Interactions;

namespace Sample.Draggable
{
    internal static class ConstrainMovement
    {
        static ConstrainMovement()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#draggableConstrain1")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions(DraggableOption.Axis, "y"));

                jQuery.Select("#draggableConstrain2")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions(DraggableOption.Axis, "x"));

                jQuery.Select("#draggableConstrain3")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions( DraggableOption.Containment, "#containment-wrapper"
                                                     , DraggableOption.Scroll, false));

                jQuery.Select("#draggableConstrain4")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions(DraggableOption.Containment, "#demo-frame"));

                jQuery.Select("#draggableConstrain5")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions(DraggableOption.Containment, "parent"));
            });
        }
    }
}
