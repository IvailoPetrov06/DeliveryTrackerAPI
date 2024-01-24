using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DeliveryTrackerAPI.Data
{
    public class Cargo : BaseEntity
    {
        public string CargoName { get; set; }
        public string Description { get; set; }
        public float Weight { get; set; }
        public int Quantity { get; set; }
    }
}
