using Business.ProductsUC;
using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OmegaSales.Controllers
{
    public class ProductsController : Controller
    {
        ProductsUC products = new ProductsUC();
        // GET: Products
        public ActionResult Index()
        {
            
            return View(products.GetProducts());
        }

        public ActionResult Delete(int id)
        {
            //ProductsUC products = new ProductsUC();
            products.delete(id);

            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            //ProductDTO proDTO = new ProductDTO();
            //products.Create(proDTO);
            //return RedirectToAction("Index");
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductDTO proDTO)
        {
            //ProductDTO proDTO = new ProductDTO();
            products.Create(proDTO);
            return RedirectToAction("Index");
            //return View();
        }
        //go go go
        //on est la pour toi hamzouchhh
        //<3
        //Et tes tests???
        //Bonjour Nicolas
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var pro=products.GetProductById(id);
            return View("Edit",pro);
        }
        [HttpPost]
        public ActionResult Edit(ProductDTO pro)
        {
            //var pro = products.GetProductById(id);
            products.Update(pro);
            return RedirectToAction("Index");
        }


    }
}