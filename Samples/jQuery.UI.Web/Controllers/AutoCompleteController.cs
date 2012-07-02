// AutoCompleteController.cs
// Script#/samples/jQuery.UI/jQuery.UI.Web/Controllers
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace jQuery.UI.Web.Controllers {
    public class AutoCompleteController : Controller {
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
            List<AutoCompleteResult> birds = new List<AutoCompleteResult>();
            birds.Add(new AutoCompleteResult("Botaurus stellaris", "Great Bittern", "Great Bittern"));
            birds.Add(new AutoCompleteResult("Tachybaptus ruficollis", "Little Grebe", "Little Grebe"));
            birds.Add(new AutoCompleteResult("Podiceps nigricollis", "Black-necked Grebe", "Black-necked Grebe"));
            birds.Add(new AutoCompleteResult("Ixobrychus minutus", "Little Bittern", "Little Bittern"));
            birds.Add(new AutoCompleteResult("Nycticorax nycticorax", "Black-crowned Night Heron", "Black-crowned Night Heron"));
            birds.Add(new AutoCompleteResult("Platalea leucorodia", "Spoonbill", "Spoonbill"));
            birds.Add(new AutoCompleteResult("Tetrao tetrix", "Black Grouse", "Black Grouse"));
            birds.Add(new AutoCompleteResult("Limosa limosa", "Black-tailed Godwit", "Black-tailed Godwit"));
            birds.Add(new AutoCompleteResult("Chlidonias niger", "Black Tern", "Black Tern"));
            birds.Add(new AutoCompleteResult("Tyto alba", "Barn Owl", "Barn Owl"));
            birds.Add(new AutoCompleteResult("Branta hrota", "Pale-bellied Brent Goose", "Pale-bellied Brent Goose"));
            birds.Add(new AutoCompleteResult("Locustella luscinioides", "Savi's Warbler", "Savi's Warbler"));

            var results = birds.Where(b => b.id.ToLower().Contains(term.ToLower())
                                        || b.label.ToLower().Contains(term.ToLower())
                                        || b.value.ToLower().Contains(term.ToLower()))
                               .ToList();

            return this.Json(results, JsonRequestBehavior.AllowGet);
        }

        public class AutoCompleteResult {
            public AutoCompleteResult(string id, string label, string value) {
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
