using Project7DayAndNight.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project7DayAndNight.Controllers
{
    public class ProductController : Controller
    {
        DayNightDbEntities db = new DayNightDbEntities();
        // GET: Product
        public ActionResult ProductList()
        {
            var values = db.TblProduct.ToList();    
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(TblProduct product)
        {
            product.ProductStatus = true;
            db.TblProduct.Add(product); 
            db.SaveChanges();
            return RedirectToAction("ProductList");
        }

        public ActionResult DeleteProduct(int id)
        {
            var value = db.TblProduct.Find(id);
            db.TblProduct.Remove(value);
            db.SaveChanges();
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            var value = db.TblProduct.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateProduct(TblProduct product)
        {
            var value = db.TblProduct.Find(product.ProductId);
            value.ProductName = product.ProductName;
            value.ProductStock = product.ProductStock;
            value.ProductStatus = true;
            db.SaveChanges();
            return RedirectToAction("ProductList");
        }
    }
}