using CSC481.Models.HotelInfo;
using HotelData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC481.Controllers
{
    public class HotelInfoController : Controller 
    {
        private IHotelInfo _hotelInfo; // using interface to access and edit customer
        public HotelInfoController(IHotelInfo hotelInfo)
        {
            _hotelInfo = hotelInfo;
        }
        public IActionResult HotelInfoIndex()
        {
            var hotelInfoModels = _hotelInfo.GetAll();
            var listingResult = hotelInfoModels
                .Select(result => new HotelInfoListingModel
                {
                    LastName = result.LastName,
                    FirstName = result.FirstName,
                    Phone = result.Phone
                });
            var hmodel = new HotelInfoIndexModel()
            {
                HotelInfo = listingResult
            };
            return View(hmodel);
        }
    }
}
