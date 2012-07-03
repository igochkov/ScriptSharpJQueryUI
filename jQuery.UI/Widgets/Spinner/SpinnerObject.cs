// SpinnerObject.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Enhance a text input for entering numeric values, with up/down buttons and arrow key handling.
    /// </summary>
    /// <remarks>
    /// <para>Spinner wraps a input of type text, adds two buttons to increment and decrement the current value, along with handling key events for the same purpose. It delegates to <a href="https://github.com/jquery/globalize">Globalize</a> for number formatting and parsing.</para><para>This widget requires some functional CSS, otherwise it won't work. If you build a custom theme, use the widget's specific CSS file as a starting point.</para>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public abstract class SpinnerObject : WidgetObject {

        protected SpinnerObject() {
        }

        [ScriptName("spinner")]
        public SpinnerObject Spinner() {
            return null;
        }

        [ScriptName("spinner")]
        public SpinnerObject Spinner(SpinnerOptions options) {
            return null;
        }

        [ScriptName("spinner")]
        public object Spinner(SpinnerMethod method, params object[] options) {
            return null;
        }

        /// <summary>
        /// Decrements the value by the specified number of pages, as defined by the page-option. Without the parameter, a single page is decremented.
        /// </summary>
        public void PageDown(int pages) {
        }


        /// <summary>
        /// Increments the value by the specified number of pages, as defined by the page-option. Without the parameter, a single page is incremented.
        /// </summary>
        public void PageUp(int pages) {
        }


        /// <summary>
        /// Decrements the value by the specified number of steps. Without the parameter, a single step is decremented.<para>If the resulting value is above the max or below the min, the value will be adjusted to the closest max or min.</para><para>If the resulting value is a step mismatch, the value will be adjusted to the closest step.</para>
        /// </summary>
        public void StepDown(int steps) {
        }


        /// <summary>
        /// Increments the value by the specified number of steps. Without the parameter, a single step is incremented.<o>If the resulting value is above the max or below the min, the value will be adjusted to the closest max or min.</o><para>If the resulting value is a step mismatch, the value will be adjusted to the closest step.</para>
        /// </summary>
        public void StepUp(int steps) {
        }


        /// <summary>
        /// Get or set the current value. Without the value parameter, returns the current value as a parsed number. Otherwise, sets the value.<para>If the value parameter is a string, its parsed based on the <code>numberFormat</code> and <code>culture</code> options.</para>
        /// </summary>
        public void Value(int value) {
        }

    }
}
