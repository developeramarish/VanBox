using System.Threading.Tasks;
using VanBox.API.Models;

namespace VanBox.API.Contracts
{
    public interface IAuthRepository
    {
         Task<User> Register(User user,string password);

         Task<User> Login(string username, string password);

         Task<bool> UserExist(string username);

    }
}