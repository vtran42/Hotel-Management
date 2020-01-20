using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelData.Models
{
    public class Staff : HotelInfo
    {
        [Required,MaxLength(9)]
        public string SocialSecurityNumber { get; set; }
        [Required, MaxLength(20)]
        public Position StaffPosition { get; set; } //Cashier, Janitor, CEO, Accounting
        public enum Position { Cashier, Janitor,CEO, Accouting}
        [MaxLength(3)]  // maximum 3 emergency contact information
        public List<EmergencyContact> EmergencyContact { get; set; }

    }
}
