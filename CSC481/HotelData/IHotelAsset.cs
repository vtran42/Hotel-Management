using HotelData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelData
{
    public interface IHotelAsset
    {
        
        IEnumerable<HotelAsset> GetAll();// Return all the hotel assets

        // Return Individual Instance Room
        HotelAsset GetByRoomNumber(int roomNumber);// get the room 
        void AddHotelRoom(HotelAsset newAsset);// add new room to the hotel
        string getBedSize(int roomNumber);
        string getRoomType(int roomNumber);
        double getRoomArea(int roomNumber);
        double getRoomPrice(int roomNumber);
    }
}
