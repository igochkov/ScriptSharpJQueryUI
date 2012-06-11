// Default.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Autocomplete
// Copyright (c) Ivaylo Gochkov, 2012
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using jQueryApi;
using jQueryApi.UI;

namespace Sample.Autocomplete
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
                    .Plugin<AutocompleteObject>()
                    .Autocomplete(new AutocompleteOptions(AutocompleteOption.Source, availableTags));
            });
        }
    }
}
