using HotelData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelData
{
    public interface IHotelInfo
    {
        // Adding Customer Inforation
        IEnumerable<HotelInfo> GetAll();
        void AddCustomerInfo(HotelInfo customerInfo);
        HotelInfo GetHoteInfo(string phone);
        HotelInfo GetByFirstLastName(string lastName, string firstName);


        // we need to add the discriminator to separate the staff and the customer
    }
}
