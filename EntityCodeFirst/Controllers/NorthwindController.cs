using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityCodeFirst.Models;

namespace EntityCodeFirst.Controllers
{
    public class NorthwindController : Controller
    {
        NorthWindContext db = new NorthWindContext();
        public ActionResult Index()
        {
            db.CategoriesTable.ToList();
            db.ProductsTable.ToList();
            return View();
        }
    }
}