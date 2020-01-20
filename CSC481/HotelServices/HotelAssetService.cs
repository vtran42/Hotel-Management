using HotelData;
using HotelData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelServices
{
    public class HotelAssetService : IHotelAsset
    {
        private HotelContext _context; // private the hotel data
        //constructor for hotelContext to access all database content
        public HotelAssetService(HotelContext context)
        {
            _context = context;
        }
        
        public void AddHotelRoom(HotelAsset newAsset)
        {
            _context.Add(newAsset);
            _context.SaveChanges(); // change to the database
        }

        public IEnumerable<HotelAsset> GetAll()
        {
            // return all Hotel Asset 
            return _context.HotelAssets
                .Include(asset => asset.Reservations);
        }

        public string getBedSize(int roomNumber)
        {
            return _context.HotelAssets
                .FirstOrDefault(asset => asset.RoomNumber == roomNumber).SizeBed;
        }

        public HotelAsset GetByRoomNumber(int roomNumber)
        {
            return _context.HotelAssets
                .Include(asset => asset.Reservations)
                .FirstOrDefault(asset => asset.RoomNumber == roomNumber);
        }

        public double getRoomArea(int roomNumber)
        {
            return _context.HotelAssets
                .FirstOrDefault(asset => asset.RoomNumber == roomNumber)
                .Area;
        }

        public double getRoomPrice(int roomNumber)
        {
            return _context.HotelAssets
                .FirstOrDefault(asset => asset.RoomNumber == roomNumber)
                .Price;
        }

        public string getRoomType(int roomNumber)
        {
            return _context.HotelAssets
                .FirstOrDefault(asset =>asset.RoomNumber == roomNumber)
                .TypeRoom;
        }
    }
}
