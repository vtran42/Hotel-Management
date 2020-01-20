using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelData.Models
{
    public class Reservation
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed),Key]
        public string ConfirmationNumber { get; set; }
        
        [Required]
        public HotelInfo Customer { get; set; }
        [Required]
        public List<HotelAsset> HotelAsset { get; set; }
        [Required]
        public DateTime Datebooking { get; set; }
        [Required]
        public DateTime DateRegisterCheckIn { get; set; }
        [Required]
        public DateTime DateRegistercheckOut { get; set; }
        [Required]
        public bool IsCheckIn { get; set; }//default by false = 0
        public bool isCheckOut { get; set; } // default by false = 0
        public Bill Bill { get; set; }
    }
}
