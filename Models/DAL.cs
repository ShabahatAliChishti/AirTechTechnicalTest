using AirTechTechnicalTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirTechTechnicalTest.Models
{
    public class DAL
    {

        AirTechTechnicalTestEntities db = new AirTechTechnicalTestEntities();

public List<HomeSearching> findhome(HomeSearchingModel model, int minPrice, int maxPrice, double maxarea, double minarea)
        {
         List<HomeSearching> list=   db.HomeSearchings.Where(x => x.Price >= minPrice && x.Price <= maxPrice && x.Area >= minarea && x.Area <= maxarea && x.LocationId == model.LocationId && x.Office == model.Office && x.Bed >= model.Bed && x.Baths >= model.Baths).ToList();
            return list;

        }
        public List<Location> locationlist()
        {
            List<Location> list = db.Locations.ToList();
            return list;

        }

    }
}