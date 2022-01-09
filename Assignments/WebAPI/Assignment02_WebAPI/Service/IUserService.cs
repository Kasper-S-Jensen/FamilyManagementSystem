using System.Threading.Tasks;
using Assignment02_WebAPI.Models;

namespace Assignment02_WebAPI.Data
{
    public interface IUserService
    {
        Task<User> ValidateUserAsync(string userName, string Password);
    }
}