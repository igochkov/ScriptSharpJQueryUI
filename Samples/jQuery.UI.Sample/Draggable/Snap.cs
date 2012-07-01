// Snap.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Draggable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Interactions;

namespace Sample.Draggable
{
    internal static class Snap
    {
        static Snap()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#draggableSnap1")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions(DraggableOption.Snap, true));

                jQuery.Select("#draggableSnap2")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions(DraggableOption.Snap, ".ui-widget-header"));

                jQuery.Select("#draggableSnap3")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions( DraggableOption.Snap, ".ui-widget-header"
                                                     , DraggableOption.SnapMode, "outer"));

                jQuery.Select("#draggableSnap4")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions(DraggableOption.Grid, new int[] { 20, 20 }));

                jQuery.Select("#draggableSnap5")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions(DraggableOption.Grid, new int[] { 80, 80 }));
            });
        }
    }
}
