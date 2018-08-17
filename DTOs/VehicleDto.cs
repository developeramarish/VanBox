using System.Collections.Generic;
using System.Collections.ObjectModel;
using VanBox.Models;

namespace VanBox.DTOs
{
    public class VehicleDto
    {
       public int Id { get; set; }
       public int ModelId { get; set; }
       public bool IsRegister { get; set; }

       public ContactDto Contact { get; set; }

       public ICollection<int> Features { get; }

       public VehicleDto()
       {
           Features = new Collection<int>();
           
       }
    }

}