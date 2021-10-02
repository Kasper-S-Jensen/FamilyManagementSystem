using S5Ex01.Models;

namespace S5Ex01.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string Password);
    }
}