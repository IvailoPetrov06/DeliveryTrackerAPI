namespace DeliveryTrackerAPI.DTOS.Response
{
    public class DeliveryResponseDto
    {
        public int DriverId { get; set; }
        public int CargoId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Status { get; set; }
    }
}
