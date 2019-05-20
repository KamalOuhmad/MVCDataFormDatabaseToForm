using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class EmployeeModel
    {
        [Range(100000,999999, ErrorMessage = "Invalid ID")]
        [Display(Name = "Emplyee ID")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage ="Enter First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email Address")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [DataType(DataType.EmailAddress)]
        [Compare("EmailAddress",ErrorMessage = "Not match")]
        [Display(Name = "Confirm Email")]
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        [StringLength(100,MinimumLength =10, ErrorMessage = "Enter Valid Length")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "not match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

    }
}