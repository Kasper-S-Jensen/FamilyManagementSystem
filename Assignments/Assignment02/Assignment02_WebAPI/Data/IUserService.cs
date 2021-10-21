using Assignment02_WebAPI.Models;

namespace Assignment02_WebAPI.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string Password);
    }
}