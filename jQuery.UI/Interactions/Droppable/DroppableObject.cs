// DroppableObject.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;
using jQueryApi.UI.Utilities;

namespace jQueryApi.UI.Interactions {

    /// <summary>
    /// Create targets for draggable elements
    /// </summary>
    /// <remarks>
    /// <para>The jQuery UI Droppable plugin makes selected elements droppable (meaning they accept being dropped on by draggables). You can specify which (individually) or which kind of draggables each will accept.</para>
    /// </remarks>
    /// <example>
    /// Makes the div droppable (a drop target for a draggable).
    /// <code>
    /// $("#draggable").draggable();    $("#droppable").droppable({      drop: function() { alert('dropped'); }    });
    /// </code>
    /// <code>
    /// <div id="droppable">Drop here</div><div id="draggable">Drag me</div>
    /// </code>
    /// </example>
    [Imported]
    [IgnoreNamespace]
    
    public class DroppableObject : WidgetObject {

        public DroppableObject() {
        }

        [ScriptName("droppable")]
        public DroppableObject Droppable() {
            return null;
        }

        [ScriptName("droppable")]
        public DroppableObject Droppable(DroppableOptions options) {
            return null;
        }
    }
}
