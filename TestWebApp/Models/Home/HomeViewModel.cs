using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestWebApp.Models.Home
{
    public class HomeViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public Enums.Gender Gender { get; set; }

        // Required and five digits long
        [Required]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Pin Number must be exactly 5 digits")]
        [Display(Name = "Pin Number")]
        public int PinNumber { get; set; }
    }
}