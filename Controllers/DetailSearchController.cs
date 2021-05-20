using AirTechTechnicalTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using AirTechTechnicalTest.ViewModels;

namespace AirTechTechnicalTest.Controllers
{
    public class DetailSearchController : Controller
    {
        AirTechTechnicalTestEntities db = new AirTechTechnicalTestEntities();

        DAL bm = new DAL();
        // GET: DetailSearch

        public ActionResult Index()
        {
            List<Location> CountryList = bm.locationlist();
            ViewBag.CountryList = new SelectList(CountryList, "LocationId", "LocationName");
            return View();
        }


        

        public ActionResult FilterHome(HomeSearchingModel model,int minPrice,int maxPrice,double maxarea,double minarea)
        {
            var filterHome = bm.findhome(model, minPrice, maxPrice,  maxarea,  minarea);
            return PartialView(@"~/Views/Shared/_Home.cshtml", filterHome);

        }
    }
}