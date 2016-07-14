using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SingleGear.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetBikes()
        {
            var db = new BikesEntities();
            var bikes = db.Bikes.ToList();
            return Json(bikes, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddBike(string newBike)
        {
            var db = new BikesEntities();
            db.Bikes.Add(new Bike() { FrameColour = newBike });
            db.SaveChanges();
            var bikes = db.Bikes.ToList();
            return Json(bikes, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteBike(Bike delBike)
        {
            var db = new BikesEntities();
            var bike = db.Bikes.Find(delBike.BikeId);
            db.Bikes.Remove(bike);
            db.SaveChanges();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}