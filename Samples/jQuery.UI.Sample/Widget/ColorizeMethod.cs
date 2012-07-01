// ColorizeMethod.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Widget
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Runtime.CompilerServices;

namespace Sample.Widget {
    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum ColorizeMethod {
        Change,
        Random,
        [ScriptName("_refresh")]
        Refresh,
        Option,
        Disable,
        Enable
    }
}
