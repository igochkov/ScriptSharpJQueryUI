// jQueryUIEventHandler.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Runtime.CompilerServices;

namespace jQueryApi.UI {

    [Imported]
    [IgnoreNamespace]
    public delegate void jQueryUIEventHandler<T>(jQueryEvent e, T uiEvent);
}
