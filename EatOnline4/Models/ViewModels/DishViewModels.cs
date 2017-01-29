using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatOnline4.Models.ViewModels
{
    public class DishViewModel
    {
        [Display(Name = "DishName")]
        [Required(ErrorMessage = "DishName is required")]
        public string DishName { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Ingredients")]
        [DataType(DataType.MultilineText)]
        public string Ingredients { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        [Display(Name = "Weight")]
        [Required(ErrorMessage = "Weight is required")]
        public int Weight { get; set; }

        [Display(Name = "Calorific")]
        public int Calorific { get; set; }

        [Display(Name = "PreparationTime")]
        public int PreparationTime { get; set; }

        [Display(Name = "Availability")]
        [Required(ErrorMessage = "Availability is required")]
        public int Availability { get; set; }

        //Relations
        public int CategoryID { get; set; }
        public virtual List<Category> Category { get; set; }
    }
}