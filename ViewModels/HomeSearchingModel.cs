using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AirTechTechnicalTest.ViewModels
{
    public class HomeSearchingModel
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        [Display(Name = "Office:")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Office is required")]
        public string Office { get; set; }
        [Display(Name = "Area:")]
        [Required(ErrorMessage = "Area is required")]
        public Nullable<double> Area { get; set; }
        [Display(Name = "Bed:")]
        [Required(ErrorMessage = "Bed is required")]
        public Nullable<int> Bed { get; set; }
        [Display(Name = "Baths:")]
        [Required(ErrorMessage = "Baths is required")]
        public Nullable<int> Baths { get; set; }
        [Display(Name = "Price:")]
        [Required(ErrorMessage = "Price is required")]
        public Nullable<decimal> Price { get; set; }

    }
}