using System;
using System.Collections.Generic;
using System.Linq;
using Assignment02_WebAPI.Models;

namespace Assignment02_WebAPI.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;
        public InMemoryUserService()
        {
            users = new[]
            {
                new User
                {
                    UserName = "Kasper",
                    Password = "123456",
                    SecurityLevel = 5
                    
                },
                new User
                {
                   UserName = "Guest",
                   Password = "123456",
                   SecurityLevel = 1
                }
            }.ToList();
        }

        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}