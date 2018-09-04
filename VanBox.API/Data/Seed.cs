using System.Collections.Generic;
using Newtonsoft.Json;
using VanBox.API.Models;

namespace VanBox.API.Data
{
    public class Seed
    {
        public DataContext Context { get; set; }
        public Seed(DataContext context)
        {
            this.Context = context;

        }

        public void SeedUser() 
        {
            var userData = System.IO.File.ReadAllText("Data/UserSeed.json");
            var users = JsonConvert.DeserializeObject<List<User>>(userData);

            foreach(var user in users)
            {
                byte[] passwordHash, passwordSalt;

                CreateHash("password", out passwordHash, out passwordSalt);

                user.Password = passwordHash;
                user.PasswordSalt = passwordSalt;
                user.Name = user.Name.ToLower();

                Context.Users.Add(user);
                Context.SaveChanges();


            }

        }

        private void CreateHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
           
        }
    }
}