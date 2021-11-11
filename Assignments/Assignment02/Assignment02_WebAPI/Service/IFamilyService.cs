using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment02_WebAPI.Models;

namespace Assignment02_WebAPI.Data
{
    public interface IFamilyService
    {
        Task<IList<Adult>> GetAdultsAsync();
        Task<IList<Family>> GetFamiliesAsync();
        Task<IList<Child>> GetChildrenAsync();
        Task AddFamilyAsync(Family family);
        Task AddAdultAsync(Family family);
        Task RemoveAdultAsync(int ID);
        Task RemoveFamilyAsync(string streetName, int houseNumber);
        Task UpdateAsync(Adult adult);
        Task UpdateAsync(Family family);
        Task<Adult> GetAdultAsync(int id);
        Task<Family> GetFamilyAsync(string streetName, int houseNumber);
    }
}