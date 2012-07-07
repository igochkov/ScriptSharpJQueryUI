// ModalForm.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Dialog
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Html;
using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.Dialog {
    internal static class ModalForm {
        static ModalForm() {
            jQuery.OnDocumentReady(delegate() {
                jQueryObject name = jQuery.Select("#name");
                jQueryObject email = jQuery.Select("#email");
                jQueryObject password = jQuery.Select("#password");
                jQueryObject allFields = jQuery.FromObject(new jQuery[] { }).Add(name).Add(email).Add(password);
                jQueryObject tips = jQuery.Select(".validateTips");

                Action<string> updateTips = new Action<string>(delegate(string t) {
                    tips.Text(t)
                        .AddClass("ui-state-highlight");

                    Window.SetTimeout(new Action(delegate() {
                        tips.RemoveClass("ui-state-highlight"); //, 1500 );
                    }), 500);
                });

                Func<jQueryObject, string, int, int, bool> checkLength = new Func<jQueryObject, string, int, int, bool>(
                    delegate(jQueryObject o, string n, int min, int max) {
                        if (o.GetValue().Length > max || o.GetValue().Length < min) {
                            o.AddClass("ui-state-error");
                            updateTips("Length of " + n + " must be between " + min + " and " + max + ".");
                            return false;
                        } else {
                            return true;
                        }
                    });

                Func<jQueryObject, RegularExpression, string, bool> checkRegexp = new Func<jQueryObject, RegularExpression, string, bool>(
                        delegate(jQueryObject o, RegularExpression regexp, string n) {
                            if (!(regexp.Test(o.GetValue()))) {
                                o.AddClass("ui-state-error");
                                updateTips(n);
                                return false;
                            } else {
                                return true;
                            }
                        });

                jQuery.Select("#dialog-form")
                      .Plugin<DialogObject>()
                      .Dialog(new DialogOptions(
                            DialogOption.AutoOpen, false,
                            DialogOption.Height, 300,
                            DialogOption.Width, 350,
                            DialogOption.Modal, true,
                            DialogOption.Buttons, new DialogOptions(
                                "Create an account", new Action(delegate() {
                                    bool bValid = true;
                                    allFields.RemoveClass("ui-state-error");

                                    bValid = bValid && checkLength(name, "username", 3, 16);
                                    bValid = bValid && checkLength(email, "email", 6, 80);
                                    bValid = bValid && checkLength(password, "password", 5, 16);

                                    bValid = bValid && checkRegexp(name, new RegularExpression("^[a-z]([0-9a-z_])+$"), "Username may consist of a-z, 0-9, underscores, begin with a letter.");
                                    // From jquery.validate.js (by joern), contributed by Scott Gonzalez: http://projects.scottsplayground.com/email_address_validation/
                                    bValid = bValid && checkRegexp(email, new RegularExpression(@"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$"), "eg. ui@jquery.com");
                                    bValid = bValid && checkRegexp(password, new RegularExpression("^([0-9a-zA-Z])+$"), "Password field only allow : a-z 0-9");

                                    if (bValid) {
                                        jQuery.Select("#users tbody")
                                              .Append("<tr>" +
                                                        "<td>" + name.GetValue() + "</td>" +
                                                        "<td>" + email.GetValue() + "</td>" +
                                                        "<td>" + password.GetValue() + "</td>" +
                                                      "</tr>");
                                        jQuery.This.Plugin<DialogObject>()
                                                   .Dialog(DialogMethod.Close);
                                    }
                                }),
                                "Cancel", new Action(delegate() {
                                    jQuery.This.Plugin<DialogObject>()
                                               .Dialog(DialogMethod.Close);
                                })),
                                DialogEvents.Close, new Action(delegate() {
                                    allFields.Value("").RemoveClass("ui-state-error");
                                })));

                jQuery.Select("#create-user")
                    .Plugin<ButtonObject>()
                    .Button()
                    .Click(new jQueryEventHandler(delegate(jQueryEvent e) {
                    jQuery.Select("#dialog-form").Plugin<DialogObject>().Dialog(DialogMethod.Open);
                }));
            });
        }
    }
}
