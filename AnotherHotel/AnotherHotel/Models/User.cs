using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnotherHotel.Models
{
    public class User
    {
        [Key]
        [Display(Name = "User ID")]
        public int userID { get; set; }     //ID for database

        [Required]
        [Display(Name = "User Name")]

        public string userName { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string password { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters long.")]              //ensures name is at least 2 charactes long
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters long.")]              //ensures name is at least 2 charactes long
        [Display(Name = "Middle Name")]
        public string middleName { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters long.")]              //ensures name is at least 2 charactes long
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Required]
        [Display(Name = "Unique Citizen Number")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "UCN must be numeric")] //endusres string has only digits
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Length should be 10.")] //ensures ЕГН is 10 characters long.
        public string UCN { get; set; } //Unique Citizen Number//ЕГН
        [Required]
        [Display(Name = "Telephone Number")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Telephone number must be numeric")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Length should be 10.")]
        public string telephoneNumber { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required]

        [DataType(DataType.Date)]
        [Display(Name = "Date Hired")]
        public DateTime hireDate { get; set; }    //dd.mm.yyyy

        [DataType(DataType.Date)]
        [Display(Name = "Date Fired")]
        public DateTime? fireDate { get; set; }   //dd.mm.yyyy
        [Required]
        [DefaultValue(true)]
        public bool active { get; set; }
    }
}
