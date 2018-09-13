using System;
using System.Collections.Generic;
using VanBox.API.Models;

namespace VanBox.API.DTOs
{
    public class UserForUpdateDTO
    {     
        public string Introduction { get; set; }
        public string Interests { get; set; }
        public string LookingFor { get; set; }
        public string Country { get; set; }
    }
}