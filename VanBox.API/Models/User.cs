namespace VanBox.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}