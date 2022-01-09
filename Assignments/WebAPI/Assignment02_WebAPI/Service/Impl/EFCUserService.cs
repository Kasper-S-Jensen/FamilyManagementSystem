using System.Threading.Tasks;
using Assignment02_WebAPI.Data;
using Assignment02_WebAPI.Models;
using Assignment02_WebAPI.Repository;

namespace Assignment02_WebAPI.Service.Impl
{
    public class EFCUserService : IUserService
    {
       

        private IUserRepository repository;

        public EFCUserService(IUserRepository repository)
        {
            this.repository = repository;
        }
        
        public Task<User> ValidateUserAsync(string userName, string Password)
        {
          return  repository.ValidateUserAsync(userName, Password);
        }
        
    }
}