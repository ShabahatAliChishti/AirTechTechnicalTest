using AirTechTechnicalTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
namespace AirTechTechnicalTest.Controllers
{
    public class DetailSearchController : Controller
    {
        AirTechTechnicalTestEntities db = new AirTechTechnicalTestEntities();
        // GET: DetailSearch
        public ActionResult Index()
        {
            List<Location> CountryList = db.Locations.ToList();
            ViewBag.CountryList = new SelectList(CountryList, "LocationId", "LocationName");
            return View();
        }


        //[HttpPost]
        public ActionResult FilterByPrice(HomeSearching model,int minPrice,int maxPrice,double maxarea,double minarea)
        {
           
            ViewBag.filterByPrice = true;
            var filterHome = db.HomeSearchings.Where(x => x.Price >= minPrice && x.Price <= maxPrice&& x.Area >= minarea && x.Area <=maxarea && x.LocationId==model.LocationId&&x.Office==model.Office&&x.Bed>=model.Bed&&x.Baths>=model.Baths).ToList();
            //return View("Products", filterProducts.ToPagedList(page ?? 1, 9));
            return PartialView(@"~/Views/Shared/_Home.cshtml", filterHome);

        }
    }
}