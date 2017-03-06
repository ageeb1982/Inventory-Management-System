using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagement.Controllers
{
    public class HomeController : Controller
    {
        // Customer Page
        public ActionResult Customer()
        {
            return View();
        }
        public ActionResult ManageCustomer()
        {
            return View();
        }

        // Supplier Page
        public ActionResult Supplier()
        {
            return View();
        }

        // Employee Page
        public ActionResult Employee()
        {
            return View();
        }

        public ActionResult ManageEmployee()
        {
            return View();
        }

        // Manage Item Page
        public ActionResult Item()
        {
            return View();
        }

        public ActionResult ManageItem()
        {
            return View();
        }

        public ActionResult ManageItemList()
        {
            return View();
        }

        public ActionResult Category()
        {
            return View();
        }
       
    }
}