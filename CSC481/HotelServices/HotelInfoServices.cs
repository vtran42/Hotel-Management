using HotelData;
using HotelData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelServices
{
    public class HotelInfoServices : IHotelInfo
    {
        private HotelContext _context;

        // constructor to able to add all method in DB context
        public HotelInfoServices(HotelContext context)
        {
            _context = context;    
        }

        public void AddCustomerInfo(HotelInfo customerInfo)
        {
            _context.Add(customerInfo); // add the customer information
            _context.SaveChanges(); // changes to the database
        }

        public IEnumerable<HotelInfo> GetAll()
        {
            return _context.HotelInfos
                .Include(info => info.PaymentInfo)
                .Include(info => info.Address);
        }

        public HotelInfo GetByFirstLastName(string lastName, string firstName)
        {
            return _context.HotelInfos
                .Include(info => info.PaymentInfo)
                .Include(info => info.Address)
                .LastOrDefault(info => info.LastName.Equals(lastName) && info.FirstName.Equals(firstName));
        }

        public HotelInfo GetHoteInfo(string phone)
        {
            return _context.HotelInfos
                .Include(info => info.PaymentInfo)
                .Include(info => info.Address)
                .FirstOrDefault(info => info.Phone.Equals(phone));
        } 
    }
}
