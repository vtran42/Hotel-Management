using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelData.Models
{
    public class Bill
    {
        public string BillId { get; set; }
        public List<Reservation> Reservation { get; set; }
        
        [Required]
        public string ExtraItemsName { get; set; }
        [Required]
        public double FinalPrice { get; set; }

        // Optional. CheckIn and CheckOut will be generate when the customer check in and check out room
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
