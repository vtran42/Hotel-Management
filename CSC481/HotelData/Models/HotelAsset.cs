using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelData.Models
{
    public class HotelAsset
    {
        /*Room Number
         * Room Type (Vip, Economic, regular)
         *  Room Status (Available, hold, or Unavailable)
         *  Number of Beds (min = 1, and max = 4)
         *  Bed Sizes (doublet, queen, king, twin)
         *  Condition (good, bad)
         *  Area (square feet)
         *  Price
         */
        // Primary key
        [MaxLength(3),Key]
        public int RoomNumber { get; set; }
        // Put the Not Null Data in the database here

        [Required]
        public string SizeBed { get; set; }
        public enum BedSize { Doublet, Queen, King, Twin}


        [Required]
        public string TypeRoom { get; set; }
        public enum RoomType {VIP, Economic, Regular}

        [Required]
        public string RoomCondition { get; set; } // true for good, False for no
        public enum Condition { Good, Bad}

        public string StatusRoom { get; set; }
        public enum RoomStatus { Available, hold, Unavailable }

        [Required]
        public double Area { get; set; }    // unit in square feet
        [Required]
        public double Price { get; set; } // $/day
        // put all the attributes is not require NOT NULL in Database here
        public Reservation Reservations { get; set; }
        // Put all the virtual function to make foreign key here

    }
}
