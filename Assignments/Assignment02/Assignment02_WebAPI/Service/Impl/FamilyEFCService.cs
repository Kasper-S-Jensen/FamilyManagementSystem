using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment02_WebAPI.Models;
using Assignment02_WebAPI.Repository;

namespace Assignment02_WebAPI.Data.Impl
{
    public class FamilyEFCService : IFamilyService
    {
        private IFamilyRepository repository;

        public FamilyEFCService(IFamilyRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            IList<Adult> adults;
            adults = await repository.GetAdultsAsync();
            return adults;
        }

        public async Task<IList<Family>> GetFamiliesAsync()
        {
            IList<Family> families;
            families = await repository.GetFamiliesAsync();
            return families;
        }

        public Task<IList<Child>> GetChildrenAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task AddFamilyAsync(Family family)
        {
           await repository.AddFamilyAsync(family);
        }

        public async Task AddAdultAsync(Family family)
        {
            await repository.AddAdultAsync(family);
        }

        public async Task RemoveAdultAsync(int ID)
        {
            await repository.RemoveAdultAsync(ID);
        }

        public async Task RemoveFamilyAsync(string streetName, int houseNumber)
        {
            await repository.RemoveFamilyAsync(streetName,houseNumber);
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