// Default.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/AutoComplete
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.AutoComplete
{
    internal static class Default
    {
        static Default()
        {
            jQuery.OnDocumentReady(delegate()
            {
                string[] availableTags = new string[] 
                {
			        "ActionScript",
			        "AppleScript",
			        "Asp",
			        "BASIC",
			        "C",
			        "C++",
			        "Clojure",
			        "COBOL",
			        "ColdFusion",
			        "Erlang",
			        "Fortran",
			        "Groovy",
			        "Haskell",
			        "Java",
			        "JavaScript",
			        "Lisp",
			        "Perl",
			        "PHP",
			        "Python",
			        "Ruby",
			        "Scala",
			        "Scheme"
                };

                jQuery.Select("#autocompleteTags")
                    .Plugin<AutoCompleteObject>()
                    .AutoComplete(new AutoCompleteOptions(AutoCompleteOption.Source, availableTags));
            });
        }
    }
}
