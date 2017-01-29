using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatOnline4.Models
{
    public class Category
    {
        [Key]
        [Display(Name = "CategoryID")]
        public int CategoryID { get; set; }

        [Display(Name = "CategoryName")]
        [Required(ErrorMessage = "CategoryName is required")]
        public string CategoryName { get; set; }

        //Relations
        public virtual Dish Dish { get; set; }
    }
}