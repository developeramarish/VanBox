using System.Threading.Tasks;
using VanBox.API.Models;
using System.Collections.Generic;

namespace VanBox.API.Contracts
{
    public interface IMatchRepository
    {
        void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T:class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetAllUser();
        Task<User> GetUser(int Id);

        Task<Photo> GetPhoto(int id);

    }
}