﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Languagy_project.Models
{
  public  class forgetpasswordVM
    {
        [Required(ErrorMessage ="Email is Required ")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
