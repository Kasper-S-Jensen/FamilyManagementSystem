using System.Threading.Tasks;
using BlazorApp.Models;

namespace BlazorApp.Data
{
    public interface IUserService
    {
        Task<User> ValidateUserAsync(string username, string Password);
    }
}