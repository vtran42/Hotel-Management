using CSC481.Models.HotelAsset;
using HotelData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC481.Controllers
{
    // handle all data come from data source
    // put to the view model to display
    public class HotelAssetController : Controller 
    {
        private IHotelAsset _assets;
        public HotelAssetController(IHotelAsset assets)
        {
            _assets = assets;
        }

        public IActionResult Index()
        {
            var assetModels = _assets.GetAll();
            // pass to the model cause we don't want to get all information
            var listingResult = assetModels
                .Select(result => new AssetIndexListingModel
                // map all assetModels to assetIndexListing Model, direct 1 to 1
                {
                    RoomNumber = result.RoomNumber,
                    GetBedSize = result.SizeBed,
                    GetRoomArea = result.Area,
                    GetRoomType = result.TypeRoom,
                    GetRoomPrice = result.Price,
                    GetRoomStatus = result.StatusRoom
                });
            // pass the new instance of AssetIndexModel
            var model = new AssetIndexModel()
            {
                Assets = listingResult
            };
            return View(model);
        }

    }
}
