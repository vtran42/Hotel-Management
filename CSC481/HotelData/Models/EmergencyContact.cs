using System.ComponentModel.DataAnnotations;

namespace HotelData.Models
{
    public class EmergencyContact
    {
        public string Id { get; set; }
        [Required,MaxLength(20)]
        public string ELastName { get; set; }
        [Required,MaxLength(20)]
        public string EFirstName { get; set; }
        [Required, MaxLength(10)]
        public string EPhone { get; set; }
        [Required, MaxLength(20)]
        public string RelativeToStaff { get; set; }
    }
}