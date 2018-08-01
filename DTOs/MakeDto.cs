

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace VanBox.DTOs
{
    public class MakeDto
    {
        public int Id { get; set; }
   
        public string Name { get; set; }

        public ICollection<MdlDto> Models {get; set;}

        public MakeDto()
        {
            Models = new Collection<MdlDto>(); 
        }
    }
}