// Default.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Position
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Interactions;
using jQueryApi.UI.Utilities;

namespace Sample.Position {
    internal static class Default {
        static Default() {
            jQuery.OnDocumentReady(delegate() {
                jQuery.Select(".positionable")
                      .CSS("opacity", "0.5");

                jQuery.Select(":input")
                      .Bind("click keyup change", new jQueryEventHandler(Position));

                jQuery.Select("#parent")
                      .Plugin<DraggableObject>()
                      .Draggable(new DraggableOptions(DraggableEvents.Drag, new jQueryEventHandler(Position)));

                Position(null);
            });
        }

        static void Position(jQueryEvent e) {
            jQuery.Select(".positionable")
                  .Plugin<PositionObject>()
                  .Position(new PositionOptions(
                            // With PositionOption "of" specified, all other examples stop working.
                            // TODO: Investigate!
                            //PositionOption.Of, jQuery.Select("#parent"),
                            PositionOption.My, jQuery.Select("#my_horizontal").GetValue() + " " + jQuery.Select("#my_vertical").GetValue(),
                            PositionOption.At, jQuery.Select("#at_horizontal").GetValue() + " " + jQuery.Select("#at_vertical").GetValue(),
                            "offset", jQuery.Select("#offset").GetValue(),
                            PositionOption.Collision, jQuery.Select("#collision_horizontal").GetValue() + " " + jQuery.Select("#collision_vertical").GetValue()
                            ));
        }
    }
}
