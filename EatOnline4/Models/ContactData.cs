using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatOnline4.Models
{
    public class ContactData
    {
        [Key]
        [Display(Name = "ContactDataID")]
        public int ContactDataID { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Display(Name = "Street")]
        [Required(ErrorMessage = "Street is required")]
        public string Street { get; set; }

        [Display(Name = "FlatNumber")]
        [Required(ErrorMessage = "FlatNumber is required")]
        public int FlatNumber { get; set; }

        [Display(Name = "PhoneNumber")]
        [Required(ErrorMessage = "PhoneNumber is required")]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }
    }
}