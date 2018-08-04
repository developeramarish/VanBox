using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace VanBox.Models
{
    [Table("Vehicles")]
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        public Model Model { get; set; }

        public int ModelId { get; set; }

        public ICollection<FeatureVehicle> FeatureVehicles { get; }

        public Vehicle(){
            FeatureVehicles = new Collection<FeatureVehicle>();
        }
    }
}