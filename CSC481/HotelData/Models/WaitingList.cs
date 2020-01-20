using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelData.Models
{
    public class WaitingList
    {
        
        public string Id { get; set; }
        [MaxLength(10)]
        public List<HotelInfo> WatingCustomer { get; set; }
        [Required]
        public DateTime CheckTime { get; set; }
    }
}
