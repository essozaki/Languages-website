﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Languagy_project.Models
{
    public class resetpasswordVM
    {
        public string Token { get; set; }

        [Required(ErrorMessage = "Email Is Required")]
        [EmailAddress(ErrorMessage = "You must Enter V alid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        [MinLength(3, ErrorMessage = "Min length 3")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        [MinLength(3, ErrorMessage = "Min length 3")]
        [Compare("Password")]
        [Display(Name = "confirm Password")]
        public string confirmPassword { get; set; }
    }
}
