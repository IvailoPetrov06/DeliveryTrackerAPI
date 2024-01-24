namespace DeliveryTrackerAPI.DTOS.Response
{
    public class CargoResponseDto
    {
        public string Name { get; set; }
        public ICollection<DeliveryResponseDto> Delivery { get; set; }
    }
}
