// Manipulation.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Tabs
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Html;
using System.Runtime.CompilerServices;
using jQueryApi;
using jQueryApi.UI;
using jQueryApi.UI.Widgets;

namespace Sample.Tabs {
    internal static class Manipulation {
        static Manipulation() {
            jQuery.OnDocumentReady(delegate() {
                jQueryObject tab_title_input = jQuery.Select("#tab_title");
                jQueryObject tab_content_input = jQuery.Select("#tab_content");
                int tab_counter = 2;

                // tabs init with a custom tab template and an "add" callback filling in the content
                TabsObject tabs
                    = jQuery.Select("#tabs6")
                            .Plugin<TabsObject>()
                            .Tabs(new TabsOptions(
                                "tabTemplate", "<li><a href='#{href}'>#{label}</a> <span class='ui-icon ui-icon-close'>Remove Tab</span></li>",
                                "add", new jQueryUIEventHandler<TabsAddEvent>(
                                    delegate(jQueryEvent @event, TabsAddEvent ui) {
                                        string tab_content = tab_content_input.GetValue() ?? ("Tab " + tab_counter + " content.");
                                        jQuery.Select(ui.Panel).Append("<p>" + tab_content + "</p>");
                                    })));

                // actual addTab function: adds new tab using the title input from the form above
                Action addTab = new Action(delegate() {
                    string tab_title = tab_title_input.GetValue() ?? ("Tab " + tab_counter);
                    //tabs.Tabs("add", "#tabs-" + tab_counter, tab_title);
                    tab_counter++;
                });

                // modal dialog init: custom buttons and a "close" callback reseting the form inside
                DialogObject dialog
                    = jQuery.Select("#dialog11")
                            .Plugin<DialogObject>()
                            .Dialog(new DialogOptions(
                                DialogOption.AutoOpen, false,
                                DialogOption.Modal, true,
                                DialogOption.Buttons, 
                                    new DialogOptions(
                                        "Add", new Action(delegate() {
                                            addTab();
                                            jQuery.This.Plugin<DialogObject>().Dialog(DialogMethod.Close);
                                        }),
                                        "Cancel", new Action(delegate() {
                                            jQuery.This.Plugin<DialogObject>().Dialog(DialogMethod.Open);
                                        })),
                                DialogMethod.Open, new Action(delegate() {
                                    tab_title_input.Focus();
                                }),
                                DialogMethod.Close, new Action(delegate() {
                                    // addTab form: calls addTab function on submit and closes the dialog
                                    jQuery.Select("form", jQuery.This)
                                          .Submit(new jQueryEventHandler(delegate(jQueryEvent e) {
                                                addTab();
                                                jQuery.This.Plugin<DialogObject>().Dialog(DialogMethod.Close);
                                                e.PreventDefault();
                                                e.StopPropagation();
                                        }));
                            })));

                // addTab button: just opens the dialog
                jQuery.Select("#add_tab")
                    .Plugin<ButtonObject>()
                    .Button()
                    .Click(new jQueryEventHandler(delegate(jQueryEvent e) {
                    dialog.Dialog(DialogMethod.Open);
                }));

                // close icon: removing the tab on click
                // note: closable tabs gonna be an option in the future - see http://dev.jqueryui.com/ticket/3924
                jQuery.Select("#tabs span.ui-icon-close")
                      .Live("click", new jQueryEventHandler(delegate(jQueryEvent e) {
                    int index = jQuery.Select("li", tabs).Index(jQuery.This.Parent()[0]);
                    tabs.Tabs(new TabsOptions(TabsEvents.Remove, index));
                }));
            });
        }
    }

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class TabsAddEvent {
        [IntrinsicProperty]
        public string Panel {
            get {
                return null;
            }
            set {
            }
        }
    }
}
