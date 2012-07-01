// AccordionObject.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;
using jQueryApi.UI.Utilities;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Convert a pair of headers and content panels into an accordion.
    /// </summary>
    /// <remarks>
    /// <para>Make the selected elements Accordion widgets.</para><para>The markup of your accordion container needs pairs of headers and content panels:</para><c><div id="accordion"><h3><a href="#">First header</a></h3><div>First content</div><h3><a href="#">Second header</a></h3><div>Second content</div></div></c><para>If you use a different element for the header, specify the header-option with an appropriate selector, eg. header: 'a.header'. The content element must be always next to its header.</para><para>If you have links inside a accordion panel and use a-elements as headers, add a class to them and use that as the header, eg. header: 'a.header'.</para><para>Use activate(Number) to change the active panel programmatically.</para><para>This widget requires some functional CSS, otherwise it won't work. If you build a custom theme, use the widget's specific CSS file as a starting point.</para>
    /// </remarks>
    /// <example>
    /// A simple jQuery UI Accordion.
    /// <code>
    /// $("#accordion").accordion();
    /// </code>
    /// <code>
    /// <div id="accordion"><h3><a href="#">Section 1</a></h3><div><para>Mauris mauris ante, blandit et, ultrices a, suscipit eget, quam. Integerut neque. Vivamus nisi metus, molestie vel, gravida in, condimentum sitamet, nunc. Nam a nibh. Donec suscipit eros. Nam mi. Proin viverra leo utodio. Curabitur malesuada. Vestibulum a velit eu ante scelerisque vulputate.</para></div><h3><a href="#">Section 2</a></h3><div><para>Sed non urna. Donec et ante. Phasellus eu ligula. Vestibulum sit ametpurus. Vivamus hendrerit, dolor at aliquet laoreet, mauris turpis porttitorvelit, faucibus interdum tellus libero ac justo. Vivamus non quam. Insuscipit faucibus urna.</para></div><h3><a href="#">Section 3</a></h3><div><para>Nam enim risus, molestie et, porta ac, aliquam ac, risus. Quisque lobortis.Phasellus pellentesque purus in massa. Aenean in pede. Phasellus ac liberoac tellus pellentesque semper. Sed ac felis. Sed commodo, magna quislacinia ornare, quam ante aliquam nisi, eu iaculis leo purus venenatis dui.</para><ul><li>List item one</li><li>List item two</li><li>List item three</li></ul></div><h3><a href="#">Section 4</a></h3><div><para>Cras dictum. Pellentesque habitant morbi tristique senectus et netuset malesuada fames ac turpis egestas. Vestibulum ante ipsum primis infaucibus orci luctus et ultrices posuere cubilia Curae; Aenean laciniamauris vel est.</para><para>Suspendisse eu nisl. Nullam ut libero. Integer dignissim consequat lectus.Class aptent taciti sociosqu ad litora torquent per conubia nostra, perinceptos himenaeos.</para></div></div>
    /// </code>
    /// </example>
    [Imported]
    [IgnoreNamespace]
    
    public class AccordionObject : WidgetObject {

        public AccordionObject() {
        }

        [ScriptName("accordion")]
        public AccordionObject Accordion() {
            return null;
        }

        [ScriptName("accordion")]
        public AccordionObject Accordion(AccordionOptions options) {
            return null;
        }

        [ScriptName("accordion")]
        public object Accordion(AccordionMethod method, params object[] options) {
            return null;
        }

        /// <summary>
        /// Recompute heights of the accordion panels. Results depend on the content and the <code>heightStyle</code> option.
        /// </summary>
        public void Refresh() {
        }

    }
}
