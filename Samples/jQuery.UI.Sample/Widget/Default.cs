// Default.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Widget
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using jQueryApi;
using jQueryApi.UI;
using jQueryApi.UI.Widgets;

namespace Sample.Widget {
    internal static class Default {
        static Default() {
            jQuery.OnDocumentReady(delegate() {
                // the widget definition, where "custom" is the namespace,
                // "colorize" the widget name
                jQueryUI.Create("custom.colorize",
                    new WidgetOptions(
                    // default options
                    "options", new ColorizeOptions(
                            ColorizeOption.Red, 255,
                            ColorizeOption.Green, 0,
                            ColorizeOption.Blue, 0,
                            ColorizeMethod.Change, null,
                            ColorizeMethod.Random, null),
                    // the constructor
                    WidgetMethod.Create, new Action(delegate() {
                    jQuery.Current
                          .Plugin<WidgetObject>()
                          .Element
                          .AddClass("custom-colorize")
                          .Plugin<jQueryUIObject>()
                          .DisableSelection();

                    jQuery.Current
                          .Plugin<ColorizeObject>()
                          .Changer = jQuery.FromHtml("<button>", new System.Collections.Dictionary("text", "change", "class", "custom-colorize-changer"))
                                           .AppendTo(jQuery.Current
                                                           .Plugin<WidgetObject>()
                                                           .Element)
                                           .Plugin<ButtonObject>()
                                           .Button();

                    // bind click events on the changer button to the random method
                    // in 1.9 would use this._bind( this.changer, { click: "random" });
                    WidgetObject that = jQuery.Current.Plugin<WidgetObject>();

                    jQuery.Current
                          .Plugin<ColorizeObject>()
                          .Changer
                          .Bind("click.colorize", delegate(jQueryEvent e) {
                                // _bind would handle this check
                                if (((ColorizeOptions)that.Options).Disabled) {
                                    return;
                                }
                                that.Plugin<ColorizeObject>().Random.Apply(that, Arguments.Current);
                          });

                    jQuery.Current
                          .Plugin<ColorizeObject>()
                          .Refresh();
                }),
                    // called when created, and later when changing options
                ColorizeMethod.Refresh, new Action(delegate() {
                    jQuery.Current
                          .Plugin<WidgetObject>()
                          .Element.CSS("background-color", "rgb(" +
                                ((ColorizeOptions)jQuery.Current.Plugin<WidgetObject>().Options).Red + "," +
                                ((ColorizeOptions)jQuery.Current.Plugin<WidgetObject>().Options).Green + "," +
                                ((ColorizeOptions)jQuery.Current.Plugin<WidgetObject>().Options).Blue + ")"
                    );

                    // trigger a callback/event
                    jQuery.Current
                          .Plugin<WidgetObject>()
                          .Trigger("change");
                }),
                // a public method to change the color to a random value
                // can be called directly via .colorize( "random" )
                ColorizeMethod.Random, new jQueryEventHandler(delegate(jQueryEvent e) {
                    ColorizeOptions colors = new ColorizeOptions(
                        ColorizeOption.Red, Math.Floor(Math.Random() * 256),
                        ColorizeOption.Green, Math.Floor(Math.Random() * 256),
                        ColorizeOption.Blue, Math.Floor(Math.Random() * 256)
                    );

                    // trigger an event, check if it's canceled
                    if (jQuery.Current
                               .Plugin<WidgetObject>()
                               .Trigger("random", e, colors)) {
                        jQuery.Current
                                .Plugin<WidgetObject>()
                                .Option(colors);
                    }
                }),
                // events bound via _bind are removed automatically
                // revert other modifications here
                WidgetMethod.Destroy, new Action(delegate() {
                    // remove generated elements
                    jQuery.Current
                          .Plugin<ColorizeObject>()
                          .Changer
                          .Remove();

                    jQuery.Current
                          .Plugin<WidgetObject>()
                          .Element
                          .RemoveClass("custom-colorize")
                          .Plugin<jQueryUIObject>()
                          .EnableSelection()
                          .CSS("background-color", "transparent");
                }),
                    // _setOptions is called with a hash of all options that are changing
                    // always refresh when changing options
                WidgetMethod.SetOptions, new Action(delegate() {
                    // in 1.9 would use _superApply( arguments)
                    ((WidgetObject)WidgetObject.Prototype).SetOptions.Apply(jQuery.Current, Arguments.Current);

                    jQuery.Current
                          .Plugin<ColorizeObject>()
                          .Refresh();
                }),
                // _setOption is called for each individual option that is changing
                WidgetMethod.SetOption, new Action<string, int>(delegate(string key, int value) {
                    // prevent invalid color values
                    if (new System.RegularExpression("red|green|blue").Test(key) && (value < 0 || value > 255)) {
                        return;
                    }
                    // in 1.9 would use _super
                    //$.Widget.prototype._setOption.call( this, key, value );
                    ((WidgetObject)WidgetObject.Prototype).SetOption.Call(jQuery.Current, key, value);
                })

                ));

                // initialize with default options
                jQuery.Select("#my-widget1")
                      .Plugin<ColorizeObject>()
                      .Colorize();

                // initialize with two customized options
                jQuery.Select("#my-widget2")
                      .Plugin<ColorizeObject>()
                      .Colorize(new ColorizeOptions(
                            ColorizeOption.Red, 60,
                            ColorizeOption.Blue, 60
                      ));

                // initialize with custom green value
                // and a random callback to allow only colors with enough green
                jQuery.Select("#my-widget3")
                    .Plugin<ColorizeObject>()
                    .Colorize(new ColorizeOptions(
                        ColorizeOption.Green, 128,
                        ColorizeMethod.Random, new Func<jQueryEvent, ColorizeOptions, bool>(delegate(jQueryEvent e, ColorizeOptions ui) {
                    return ui.Green > 128;
                })
                ));

                // click to toggle enabled/disabled
                jQuery.Select("#disable").Toggle(
                    new jQueryEventHandler(delegate(jQueryEvent e) {
                    // use the custom selector created for each widget to find all instances
                    jQuery.Select(":custom-colorize")
                          .Plugin<ColorizeObject>()
                          .Colorize(ColorizeMethod.Disable);
                }),
                    new jQueryEventHandler(delegate(jQueryEvent e) {
                    jQuery.Select(":custom-colorize")
                          .Plugin<ColorizeObject>()
                          .Colorize(ColorizeMethod.Enable);
                }));

                // click to set options after initalization
                jQuery.Select("#black").Click(delegate(jQueryEvent e) {
                    jQuery.Select(":custom-colorize")
                          .Plugin<ColorizeObject>()
                          .Colorize(ColorizeMethod.Option, new ColorizeOptions(
                                ColorizeOption.Red, 0,
                                ColorizeOption.Green, 0,
                                ColorizeOption.Blue, 0
                           ));
                });
            });
        }
    }
}
