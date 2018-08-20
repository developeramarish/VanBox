using System.ComponentModel.DataAnnotations;

namespace VanBox.API.DTOs
{
    public class UserLoginDTO
    {  
        public string Name { get; set; }
        public string Password { get; set; }
       
    }
}