using System.ComponentModel.DataAnnotations;

namespace DeliveryTrackerAPI.DTOS.Requests
{
    public class DriverRequestDto : BaseRequestDto
    {
        [Required]
        [MinLength(2)]
        [MaxLength(60)]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(60)]
        public string LicenseNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
