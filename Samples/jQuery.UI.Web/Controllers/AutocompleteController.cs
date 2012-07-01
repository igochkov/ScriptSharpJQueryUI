// AutocompleteController.cs
// Script#/samples/jQuery.UI/jQuery.UI.Web/Controllers
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace jQuery.UI.Web.Controllers {
    public class AutocompleteController : Controller {
        public ActionResult Default() {
            return View();
        }

        public ActionResult RemoteDatasource() {
            return View();
        }

        public ActionResult RemoteWithCaching() {
            return View();
        }

        public ActionResult RemoteJSONPDatasource() {
            return View();
        }

        public ActionResult ScrollableResults() {
            return View();
        }

        public ActionResult Combobox() {
            return View();
        }

        public ActionResult CustomDataAndDisplay() {
            return View();
        }

        public ActionResult XMLDataParsedOnce() {
            return View();
        }

        public ActionResult Categories() {
            return View();
        }

        public ActionResult AccentFolding() {
            return View();
        }

        public ActionResult MultipleValues() {
            return View();
        }

        public ActionResult MultipleRemote() {
            return View();
        }

        public virtual JsonResult Search(string term) {
            List<AutocompleteResult> birds = new List<AutocompleteResult>();
            birds.Add(new AutocompleteResult("Botaurus stellaris", "Great Bittern", "Great Bittern"));
            birds.Add(new AutocompleteResult("Tachybaptus ruficollis", "Little Grebe", "Little Grebe"));
            birds.Add(new AutocompleteResult("Podiceps nigricollis", "Black-necked Grebe", "Black-necked Grebe"));
            birds.Add(new AutocompleteResult("Ixobrychus minutus", "Little Bittern", "Little Bittern"));
            birds.Add(new AutocompleteResult("Nycticorax nycticorax", "Black-crowned Night Heron", "Black-crowned Night Heron"));
            birds.Add(new AutocompleteResult("Platalea leucorodia", "Spoonbill", "Spoonbill"));
            birds.Add(new AutocompleteResult("Tetrao tetrix", "Black Grouse", "Black Grouse"));
            birds.Add(new AutocompleteResult("Limosa limosa", "Black-tailed Godwit", "Black-tailed Godwit"));
            birds.Add(new AutocompleteResult("Chlidonias niger", "Black Tern", "Black Tern"));
            birds.Add(new AutocompleteResult("Tyto alba", "Barn Owl", "Barn Owl"));
            birds.Add(new AutocompleteResult("Branta hrota", "Pale-bellied Brent Goose", "Pale-bellied Brent Goose"));
            birds.Add(new AutocompleteResult("Locustella luscinioides", "Savi's Warbler", "Savi's Warbler"));

            var results = birds.Where(b => b.id.ToLower().Contains(term.ToLower())
                                        || b.label.ToLower().Contains(term.ToLower())
                                        || b.value.ToLower().Contains(term.ToLower()))
                               .ToList();

            return this.Json(results, JsonRequestBehavior.AllowGet);
        }

        public class AutocompleteResult {
            public AutocompleteResult(string id, string label, string value) {
                this.id = id;
                this.label = label;
                this.value = value;
            }

            public string id { get; set; }
            public string label { get; set; }
            public string value { get; set; }
        }
    }
}
