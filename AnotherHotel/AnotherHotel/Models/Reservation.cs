using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnotherHotel.Models
{
    public class Reservation
    {
        [Key]
        [Display(Name = "Reservation ID")]
        public int reservationID { get; set; } //database ID
        [Required]
        [Display(Name = "Room Rented")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Room number must be numeric")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "Length should be 3.")] //Ensures room numbers are exactly 3 characters long
        public string roomRented { get; set; }
        [Required]
        [Display(Name = "Clients")]
        public List<Client> client { get; set; }//list of client to be accomodated in given room
        [Required]
        [Display(Name = "Registration Made By")]
        public int userRegistrator { get; set; }
        [Required]
        [Display(Name = "Date of Accomodation")]
        public string dateOfAccomodation { get; set; }
        [Required]
        [Display(Name = "Date of Leave")]
        public string dateOfLeave { get; set; }
        [Required]
        [Display(Name = "Included Breakfast")]
        public bool includedBreakfast { get; set; }
        [Required]
        [Display(Name = "All Inclusive")]
        public bool allInclusive { get; set; }
        [Required]

        [Display(Name = "Price to be paid")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Price must be numeric")]
        public double priceOwed { get; set; }
    }
}
