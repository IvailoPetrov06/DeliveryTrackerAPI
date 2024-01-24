using System.ComponentModel.DataAnnotations;

namespace DeliveryTrackerAPI.DTOS.Requests
{
    public class DeliveryRequestDto : BaseRequestDto
    {
        [Required]
        [MinLength(2)]
        [MaxLength(60)]
        public int DriverId { get; set; }
        public int CargoId { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(60)]
        public DateTime DeliveryDate { get; set; }
        public string Status { get; set; }
    }
}
