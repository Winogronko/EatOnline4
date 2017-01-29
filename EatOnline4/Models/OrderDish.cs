using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatOnline4.Models
{
    public class OrderDish
    {
        [Key]
        [Display(Name = "OrderDishID")]
        public int OrderDishID { get; set; }

        [Display(Name = "Count")]
        [Required(ErrorMessage = "Count is required")]
        public int Count { get; set; }

        //Relations
        public virtual Dish Dish { get; set; }
        public virtual Basket Basket { get; set; }
        public virtual Order Order { get; set; }
    }
}