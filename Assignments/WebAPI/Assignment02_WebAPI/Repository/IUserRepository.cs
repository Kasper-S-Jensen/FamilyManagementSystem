using System.Threading.Tasks;
using Assignment02_WebAPI.Models;

namespace Assignment02_WebAPI.Repository
{
    public interface IUserRepository
    {
        Task<User> ValidateUserAsync(string userName, string Password);
    }
}