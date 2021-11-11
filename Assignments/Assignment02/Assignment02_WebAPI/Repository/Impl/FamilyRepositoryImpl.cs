using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment02_WebAPI.Models;

namespace Assignment02_WebAPI.Repository.Impl
{
    public class FamilyRepositoryImpl : IFamilyRepository
    {
        public Task<IList<Adult>> GetAdultsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Family>> GetFamiliesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Child>> GetChildrenAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task AddFamilyAsync(Family family)
        {
            throw new System.NotImplementedException();
        }

        public Task AddAdultAsync(Family family)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveAdultAsync(int ID)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveFamilyAsync(string streetName, int houseNumber)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Adult adult)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Family family)
        {
            throw new System.NotImplementedException();
        }

        public Task<Adult> GetAdultAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Family> GetFamilyAsync(string streetName, int houseNumber)
        {
            throw new System.NotImplementedException();
        }
    }
}