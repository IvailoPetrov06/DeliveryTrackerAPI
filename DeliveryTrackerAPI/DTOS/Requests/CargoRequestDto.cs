using System.ComponentModel.DataAnnotations;

namespace DeliveryTrackerAPI.DTOS.Requests
{
    public class CargoRequestDto : BaseRequestDto
    {
        [Required]
        public string CargoName { get; set; }
    }
}
