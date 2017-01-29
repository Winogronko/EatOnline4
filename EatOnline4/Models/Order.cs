using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatOnline4.Models
{
    public class Order
    {
        [Key]
        [Display(Name = "OrderID")]
        public int OrderID { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "State is required")]
        public string State { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "OrderDate")]
        [Required(ErrorMessage = "OrderDate is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OderDate { get; set; }

        //Relations
        public virtual ContactData ContactData { get; set; }
    }
}