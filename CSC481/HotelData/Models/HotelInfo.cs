using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelData.Models
{
    // class contain information of customer and staff
    public class HotelInfo
    {
        public string Id { get; set; }

        [Required, MaxLength(20)]
        public string LastName { get; set; }

        [Required, MaxLength(20)]
        public string FirstName { get; set; }

        [Required, MaxLength(20)]
        public string MiddleName { get; set; }

        [Required, MaxLength(10)]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string CustomerStatus { get; set; }
        //public enum Status { Regular, Premium,Silver, Gold}

        [MaxLength(5)]
        public List<PaymenInfo> PaymentInfo { get; set; }
        public List<Address> Address { get; set; }
    }
}