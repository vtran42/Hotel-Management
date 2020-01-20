using System.ComponentModel.DataAnnotations;

namespace HotelData.Models
{
    public class PaymenInfo
    {
        public string Id { get; set; }
        [Required,MaxLength(16)]
        public string CardNumber { get; set; }
        [Required,MaxLength(25)]
        public string CardType { get; set; }
        [Required,MaxLength(8)]
        public string SecurityCode { get; set; }
        [Required,MaxLength(2)]
        public string MonthExpired { get; set; }
        [Required,MaxLength(2)]
        public string YearExpired { get; set; }
    }
}