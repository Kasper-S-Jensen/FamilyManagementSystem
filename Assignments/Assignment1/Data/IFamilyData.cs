using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment1.Models;

namespace Assignment1.Data
{
    public interface IFamilyData
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