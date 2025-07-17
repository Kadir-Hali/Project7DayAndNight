using Project7DayAndNight.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project7DayAndNight.Controllers
{
    public class CategoryController : Controller
    {
        DayNightDbEntities db = new DayNightDbEntities();   
        // GET: Category
        public ActionResult CategoryList()
        {
            var values = db.TblCategory.ToList();
            return View(values);
        }
    }
}