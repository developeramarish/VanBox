using System;
using System.Collections.Generic;
using VanBox.API.Models;

namespace VanBox.API.DTOs
{
    public class UserForListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastActive { get; set; }
        public string KnowAs { get; set; }
        public string Interests { get; set; }
        public string Country { get; set; }
        public string PhotoUrl { get; set; }

    }
}