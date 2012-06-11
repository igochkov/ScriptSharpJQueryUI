// Portlets.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Sortable
// Copyright (c) Ivaylo Gochkov, 2012
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using jQueryApi;
using jQueryApi.UI;

namespace Sample.Sortable
{
    internal static class Portlets
    {
        static Portlets()
        {
            jQuery.OnDocumentReady(delegate() {
                jQuery.Select(".column")
                      .Plugin<SortableObject>()
                      .Sortable(new SortableOptions(SortableOption.ConnectWith, ".column"));

                jQuery.Select(".portlet")
                      .AddClass("ui-widget ui-widget-content ui-helper-clearfix ui-corner-all")
                      .Find(".portlet-header")
                          .AddClass("ui-widget-header ui-corner-all")
                          .Prepend("<span class='ui-icon ui-icon-minusthick'></span>")
                          .End()
                      .Find(".portlet-content");

                jQuery.Select(".portlet-header .ui-icon")
                    .Click(delegate(jQueryEvent e) {
                        jQuery.This
                              .ToggleClass("ui-icon-minusthick")
                              .ToggleClass("ui-icon-plusthick");

                        jQuery.This
                              .Parents(".portlet:first")
                              .Find(".portlet-content")
                              .Toggle();
                });
            });
        }
    }
}
