// AccordionOption.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum AccordionOption {

        /// <summary>
        /// The zero-based index of the panel that is active (open). A negative value select panels going backward from the last panel.<para>When collapsible is set to true, a false value closes the accordion, otherwise nothing happens</para>
        /// </summary>
        Active,

        /// <summary>
        /// If and how to animate changing panels:<ul><li>string; name of easing to use with default duration</li><li>number, duration in milliseconds with default easing</li><li>object with easing and duration options</li><li>can also contain a down option with any of the above options</li><li>"down" animations occur when the panel being activated has a lower index than the currently active panel</li><li>null/false disables animation</li></ul>
        /// </summary>
        Animate,

        /// <summary>
        /// Whether all the sections can be closed at once. Allows collapsing the active section.
        /// </summary>
        Collapsible,

        /// <summary>
        /// Disables the accordion if set to true.
        /// </summary>
        Disabled,

        /// <summary>
        /// The event on which to trigger the accordion.
        /// </summary>
        Event,

        /// <summary>
        /// Selector for the header element.<para>Must be a selector that applies to the accordion container element, via .find()</para><para>The default covers both ul/li accordions, as well as flat structures like dl/dt/dd</para>
        /// </summary>
        Header,

        /// <summary>
        /// Controls the height of the accordion and each panel. Possible values:<ul><li>auto: all panels will be set to the height of the tallest panel</li><li>fill: expand to the available height based on the accordion's parent height</li><li>content: each panel will be only as tall as its content</li></ul>
        /// </summary>
        HeightStyle,

        /// <summary>
        /// Icons to use for headers, matching an icon defined by the jQuery UI CSS Framework. Set to false to have no icons displayed.<ul><li>header (string, default: "ui-icon-triangle-1-e")</li><li>activeHeader (string, default: "ui-icon-triangle-1-s")</li></ul>
        /// </summary>
        Icons
    }
}
