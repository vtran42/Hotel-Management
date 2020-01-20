using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC481.Models.HotelAsset
{
    public class AssetIndexModel
    {
        //wrap collection of AssetIndexListing model
        public IEnumerable<AssetIndexListingModel> Assets { get; set; }
    }
}
