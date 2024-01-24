using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DeliveryTrackerAPI.Data
{
    public class Delivery : BaseEntity
    {
        [ForeignKey(nameof(Cargo))]
        public int CargoId { get; set; }
        [JsonIgnore]
        public virtual Cargo? Cargo { get; set; }

        public DateTime DeliveryDate { get; set; }
        public string Status { get; set; }
    }
}
