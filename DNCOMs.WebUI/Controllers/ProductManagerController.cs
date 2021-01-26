using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DNCOMs.Core.Models;
using DNCOMs.DataAcces.InMemory;

namespace DNCOMs.WebUI.Controllers
{
    public class ProductManagerController : Controller
    {
     

        // GET: ProductManager
        public ActionResult Index()
        {
            
            return View();
        }
    }
}