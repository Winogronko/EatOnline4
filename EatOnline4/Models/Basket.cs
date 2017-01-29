using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatOnline4.Models
{
    public class Basket
    {
        [Key]
        [Display(Name = "BasketID")]
        public int BasketID { get; set; }

        //Relations
        public virtual User User { get; set; }
    }
}