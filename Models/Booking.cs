using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingService.Models
{
    public class Booking
    {
        [Key]
        public int Booking_Id { get; set; }
        public int User_Id { get; set; }
        public int Item_Id { get; set; }
        public double Cost { get; set; }
        public string Item_Name { get; set; }
        public string Category { get; set; }

    }
}


