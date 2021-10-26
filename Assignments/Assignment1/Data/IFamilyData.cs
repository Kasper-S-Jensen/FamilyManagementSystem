using System.Collections.Generic;
using Assignment1.Models;

namespace Assignment1.Data
{
    public interface IFamilyData
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