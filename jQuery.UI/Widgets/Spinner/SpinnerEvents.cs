// SpinnerEvents.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum SpinnerEvents {

        /// <summary>
        /// Triggered when the value of the spinner has changed and the input is no longer focused.
        /// </summary>
        Change,

        /// <summary>
        /// This event is triggered when the spinner is created.
        /// </summary>
        Create,

        /// <summary>
        /// Triggered during increment/decrement (to determine direction of spin compare current value with ui.value).<para>Can be cancelled, preventing the provided value to be set, firing <code>stop</code> and, if appropiate, <code>change</code> events.</para>
        /// </summary>
        Spin,

        /// <summary>
        /// Triggered before a spin. Can be cancelled, preventing all other events to fire.
        /// </summary>
        Start,

        /// <summary>
        /// Triggered after a spin.
        /// </summary>
        Stop
    }
}
