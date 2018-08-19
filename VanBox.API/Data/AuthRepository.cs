using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VanBox.API.Contracts;
using VanBox.API.Models;

namespace VanBox.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        public DataContext Context { get; set; }
        public AuthRepository(DataContext context)
        {
            this.Context = context;

        }
        public async Task<User> Login(string username, string password)
        {
            var user = await Context.Users.FirstOrDefaultAsync(x =>x.Name == username);

            if(user == null)
                return null;

            if(!VerifyPasswordHash(password,user.Password,user.PasswordSalt))           
                return null;

            return user;

        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for(int i = 0;i<hash.Length ; i++)
                {
                    if(passwordHash[i] != hash[i])
                        return false;
                }

                return true;

            }
        }

        public async Task<User> Register(User user, string password)
        {
            byte[] passwordHash, passwordSalt;

            CreateHash(password,out passwordHash, out passwordSalt);

            user.Password = passwordHash;
            user.PasswordSalt = passwordSalt;

            await Context.Users.AddAsync(user);
            await Context.SaveChangesAsync();

            return user;
        }

        private void CreateHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
           
        }

        public async Task<bool> UserExist(string username)
        {
            if(await Context.Users.AnyAsync(x =>x.Name == username))
                return true;

            return false;
            
        }
    }
}