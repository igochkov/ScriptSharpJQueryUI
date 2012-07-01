// RevertPosition.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Draggable
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Interactions;

namespace Sample.Draggable
{
    internal static class RevertPosition
    {
        static RevertPosition()
        {
            jQuery.OnDocumentReady(delegate()
            {
                jQuery.Select("#draggableRevert1")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions(DraggableOption.Revert, true));

                jQuery.Select("#draggableRevert2")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions( DraggableOption.Revert, true
                                                     , DraggableOption.Helper, "clone"));
            });
        }
    }
}
