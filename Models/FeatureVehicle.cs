using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VanBox.Models
{
    [Table("FeatureVehicles")]
    public class FeatureVehicle
    {
        public Vehicle Vehicle { get; set; }

        public int VehicleId { get; set; } 
        
        public Feature Feature { get; set; }

        public int FeatureId { get; set; }
    }
}