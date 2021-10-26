using System.Collections.Generic;
using Assignment02_WebAPI.Models;

namespace Assignment02_WebAPI.Data
{
    public interface IFamilyData
    {
        IList<Adult> GetAdults();
        IList<Family> GetFamilies();
        IList<Child> GetChildren();
        void AddFamily(Family family);
        void AddAdult(Family family);
        void RemoveAdult(int ID);
        void RemoveFamily(string streetName, int houseNumber);
        void Update(Adult adult);
        void Update(Family family);
        Adult GetAdult(int id);
        Family GetFamily(string streetName, int houseNumber);
    }
}