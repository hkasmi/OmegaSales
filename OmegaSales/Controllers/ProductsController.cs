using Business.ProductsUC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OmegaSales.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            ProductsUC products = new ProductsUC();
            return View(products.GetProducts());
        }


    }
}