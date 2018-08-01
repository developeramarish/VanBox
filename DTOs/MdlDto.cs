using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VanBox.DTOs
{  
    public class MdlDto
    {
        public int Id { get; set; }       
        public string Name { get; set; }

        public ICollection<FeatureDto> Features { get; set; }

        public MdlDto()
        {
            Features = new Collection<FeatureDto>();
            
        }

    }
}