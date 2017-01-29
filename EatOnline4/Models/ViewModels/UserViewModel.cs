using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatOnline4.Models.ViewModels
{
    public class UserViewModel
    {

        [Display(Name = "UserName")]
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }

        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }

        /*
        [Display(Name = "UserRole")]
        public int UserRole { get; set; }
        */

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3]\.)|(([\w-]+\.)+))([a-zA-Z{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter valid email.")]﻿
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Please confirm your password")]
        public string ConfirmPassword { get; set; }


        public string AuthSecurity { get; set; }

        /*
        [DataType(DataType.Date)]
        [Display(Name = "DateJoined")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateJoined { get; set; }
        */

        //Relations
        public int RoleID { get; set; }

        public virtual List<Basket> Basket { get; set; }
        public virtual List<Role> Role { get; set; }
    }
}