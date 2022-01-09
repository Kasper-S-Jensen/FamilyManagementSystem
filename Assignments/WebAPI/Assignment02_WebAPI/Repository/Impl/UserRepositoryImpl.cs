using System;
using System.Linq;
using System.Threading.Tasks;
using Assignment02_WebAPI.Models;
using Assignment02_WebAPI.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Assignment02_WebAPI.Repository.Impl
{
    public class UserRepositoryImpl: IUserRepository
    {
        public async Task<User> ValidateUserAsync(string userName, string Password)
        {
            using (FamilyDBContext context = new FamilyDBContext())
            {
                User first = await context.Users.FirstOrDefaultAsync(user => user.UserName.Equals(userName));
                if (first == null)
                {
                    throw new Exception("User not found");
                }

                if (!first.Password.Equals(Password))
                {
                    throw new Exception("Incorrect password");
                }

                return first;
            }
           
        }
    }
}