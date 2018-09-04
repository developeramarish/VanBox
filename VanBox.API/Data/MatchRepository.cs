using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VanBox.API.Contracts;
using VanBox.API.Models;

namespace VanBox.API.Data
{
    public class MatchRepository : IMatchRepository
    {
        private readonly DataContext context;
        public MatchRepository(DataContext context)
        {
            this.context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            context.Remove(entity);
        }

        public async Task<IEnumerable<User>> GetAllUser()
        {
            var users = await context.Users.Include(p => p.Photos).ToListAsync();
            return users;
        }

        public async Task<User> GetUser(int Id)
        {
            var user = await context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id == Id);
            return user;
        }

        public async Task<bool> SaveAll()
        {
            return await context.SaveChangesAsync() > 0;           
        }
    }
}