using System.Collections.Generic;
using Assignment02_WebAPI.Models;

namespace Assignment02_WebAPI.Data
{
    public interface IAdultData
    {
        IList<Adult> GetAdults();
        IList<Family> GetFamilies();
        IList<Child> GetChildren();
        void AddFamily(string streetName, int houseNumber);
        void AddAdult(string firstName, string lastName, string hairColor, string eyeColor, int age, float weight, int height, string sex, string jobtitle, int salary, string streetName, int houseNumber);
        void RemoveAdult(int ID);
        void RemoveFamily(string streetName, int houseNumber);
        void Update(Adult adult);
        Adult GetAdult(int id);
        Family GetFamily(string streetName, int houseNumber);
    }
}