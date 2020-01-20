using System.ComponentModel.DataAnnotations;

namespace HotelData.Models
{
    //Address (street, Apt, City, State, ZipCode)
    public class Address
    {
        public string AddressId { get; set; }
        [Required,MaxLength(50)]
        public string street { get; set; }
        [Required,MaxLength(5)]
        public string AptNumber { get; set; }
        [Required,MaxLength(2)]
        public string State { get; set; }
        [Required,MaxLength(5)]
        public string ZipCode { get; set; }
    }
}