using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryTrackerAPI.Data
{
    public class DriverDeliveries
    {
        [ForeignKey(nameof(Driver))]
        public int DriverId { get; set; }
        public virtual Driver? Driver { get; set; }

        [ForeignKey(nameof(Delivery))]
        public int DeliveryId { get; set; }
        public virtual Delivery? Delivery { get; set; }
    }
}
