using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatOnline4.Models
{
    public class Role
    {
        [Key]
        [Display(Name = "RoleID")]
        public int RoleID { get; set; }

        [Display(Name = "RoleName")]
        [Required(ErrorMessage = "RoleName is required")]
        public string RoleName { get; set; }

        //Relations
        //public virtual User User { get; set; }
    }
}