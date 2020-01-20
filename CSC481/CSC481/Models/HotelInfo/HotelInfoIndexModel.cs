using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC481.Models.HotelInfo
{
    public class HotelInfoIndexModel
    {
        public IEnumerable<HotelInfoListingModel> HotelInfo { get; set; }
    }
}
