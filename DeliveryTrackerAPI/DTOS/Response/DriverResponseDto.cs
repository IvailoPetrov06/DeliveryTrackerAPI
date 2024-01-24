using System.ComponentModel.DataAnnotations;

namespace DeliveryTrackerAPI.DTOS.Response
{
    public class DriverResponseDto
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<DeliveryResponseDto> Delivery { get; set; }
    }
}
