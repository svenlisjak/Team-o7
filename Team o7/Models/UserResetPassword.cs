using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jaj.Models
{
    public class userResetPassword
    {


        [Display(Name = "Username")]       
        public string Username { get; set; }

        [Display(Name = "Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email adress is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Display(Name ="New password")]
        [Required]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimum 6 characters required")]
        public string Password { get; set; }


        [Display(Name = "Confirm new password")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Passwords have to be the same")]
        public string Password2 { get; set; }

    }
}