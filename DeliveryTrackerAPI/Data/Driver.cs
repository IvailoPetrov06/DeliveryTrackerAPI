using System.Text.Json.Serialization;

namespace DeliveryTrackerAPI.Data
{
    public class Driver : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        [JsonIgnore]
        public virtual ICollection<Delivery>? Deliveries { get; set; }
    }
}
