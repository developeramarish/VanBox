using System.ComponentModel.DataAnnotations;

namespace VanBox.API.DTOs
{
    public class UserDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(10,MinimumLength=6,ErrorMessage="Specify password between 6 to 10 charecters")]
        public string Password { get; set; }
       
    }
}