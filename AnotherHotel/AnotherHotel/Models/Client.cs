using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnotherHotel.Models
{
    public class Client
    {
        [Key]
        [Display(Name = "Client ID")]
        public int clientID { get; set; } //database ID
        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Required]
        [Display(Name = "Telephone number")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Telephone must be numeric")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Length should be 10.")] //Ensures tel num is exactly 10 characters
        public string telephoneNumber { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required]
        [Display(Name = "Adult")]
        public bool adult { get; set; }
    }
}
