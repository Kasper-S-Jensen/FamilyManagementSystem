using System.Collections.Generic;
using Assignment1.Models;

namespace Assignment1.Data
{
    public interface IAdultData
    {
        IList<Adult> GetAdults();
        IList<Child> GetChildren();
        void AddFamily(Family family);
        void RemoveAdult(int ID);
        void Update(Adult adult);
        Adult Get(int id);
    }
}