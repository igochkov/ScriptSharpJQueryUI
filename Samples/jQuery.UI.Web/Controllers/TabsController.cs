// TabsController.cs
// Script#/samples/jQuery.UI/jQuery.UI.Web/Controllers
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Threading;
using System.Web.Mvc;

namespace jQuery.UI.Web.Controllers {
    public class TabsController : Controller {
        public ActionResult Default() {
            return View();
        }

        public ActionResult Ajax() {
            return View();
        }

        public ActionResult MouseOver() {
            return View();
        }

        public ActionResult Collapsible() {
            return View();
        }

        public ActionResult Sortable() {
            return View();
        }

        public ActionResult Manipulation() {
            return View();
        }
        
        public ActionResult Bottom() {
            return View();
        }

        public ActionResult Cookie() {
            return View();
        }

        public ActionResult Content3Slow() {
            Thread.Sleep(1000);
            return View();
        }

        public ActionResult Content4Broken() {
            throw new Exception("Demo");
        }
    }
}
