using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnotherHotel.Models
{
    public class Room
    {
        [Key]
        [Display(Name = "Room ID")]
        public int roomID { get; set; } //database ID
        [Required]
        [Display(Name = "Capacity")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Capacity must be numeric")]
        public int capacity { get; set; }
        [Required]
        [Display(Name = "Type")]

        public string type { get; set; } //4 types see sap notebook
        [Required]
        [Display(Name = "Occupied")]
        public bool occupied { get; set; }
        [Required]
        [Display(Name = "Price per Bed Adult")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Price must be numeric")]
        public double priceBedAdult { get; set; }
        [Required]
        [Display(Name = "Price per Bed Child")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Price must be numeric")]
        public double priceBedChild { get; set; }
        [Required]
        [Display(Name = "Number")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Number must be numeric")]
        public int number { get; set; }
    }
}
