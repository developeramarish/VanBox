using System;
using Microsoft.AspNetCore.Http;

namespace VanBox.API.DTOs
{
    public class PhotoForCreatorDto
    {
        public string Url { get; set; }
        public IFormFile File { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string PublicId { get; set; }
    
        public PhotoForCreatorDto()
        {
            DateAdded = DateTime.Now;            
        }
    
    }

}