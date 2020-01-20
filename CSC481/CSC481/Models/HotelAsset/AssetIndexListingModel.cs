using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC481.Models.HotelAsset
{
    public class AssetIndexListingModel
    {
        public int RoomNumber { get; set; }
        public string GetBedSize { get; set; }
        public string GetRoomType { get; set; }
        public double GetRoomArea { get; set; }
        public double GetRoomPrice { get; set; }
        public string GetRoomStatus { get; set; }
    }
}
