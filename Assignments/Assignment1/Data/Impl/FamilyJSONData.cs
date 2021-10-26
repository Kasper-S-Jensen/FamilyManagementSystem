using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Assignment1.Pages;
using Assignment1.Models;
using Assignment1.Persistence;


namespace Assignment1.Data.Impl
{
    public class FamilyJSONData : IFamilyData
    {
        private FileContext familyFile;
        IList<Adult> adults = new List<Adult>();
        IList<Family> families = new List<Family>();
        IList<Child> children = new List<Child>();

        public FamilyJSONData(FileContext familyFile)
        {
            this.familyFile = familyFile;
        }

        public IList<Adult> GetAdults()
        {
            adults.Clear();
            {
                foreach (var family in familyFile.Families)
                {
                    foreach (var adult in family.Adults)
                    {
                        adults.Add(adult);
                    }
                }
            }
            return adults;
        }

        public IList<Family> GetFamilies()
        {
            families.Clear();
            {
                foreach (var family in familyFile.Families)
                {
                  families.Add(family);
                }
            }
            return families;
        }

        public IList<Child> GetChildren()
        {
            children.Clear();
            {
                foreach (var family in familyFile.Families)
                {
                    foreach (var child in family.Children)
                    {
                        children.Add(child);
                    }
                }
            }
            return children;
        }

        public void AddFamily(string streetName, int houseNumber)
        {
           
            
            Family toAdd;
            toAdd = new Family()
            {
                StreetName = streetName,
                HouseNumber = houseNumber,
                Adults = new List<Adult>(),
                Children = new List<Child>(),
                Pets = new List<Pet>()
            };
            foreach (var family in familyFile.Families)
            {
                if (streetName.Equals(family.StreetName) && houseNumber==family.HouseNumber)
                {
                    throw new Exception("Family already exists");
                }
                
            }
            familyFile.Families.Add(toAdd);
            familyFile.SaveChanges();
           
           
        }

        public void AddAdult(string firstName, string lastName, string hairColor, string eyeColor, int age, float weight, int height, string sex, string jobtitle, int salary, string streetName, int houseNumber)
        {
            Job jobToAdd = new Job()
            {
                JobTitle = jobtitle,
                Salary = salary
            };
            Adult toAdd = new Adult()
            {
                FirstName = firstName,
                LastName = lastName,
                HairColor = hairColor,
                EyeColor = eyeColor,
                Age = age,
                Weight = weight,
                Height = height,
                Sex = sex,
                JobTitle = jobToAdd
            };
            Family chosenFamily = GetFamily(streetName,houseNumber);
            
                if (chosenFamily.Adults.Count==2)
                {
                    throw new Exception("Family already has max number of adults");
                }

                foreach (var family in familyFile.Families)
                {
                    if (family.StreetName.Equals(chosenFamily.StreetName)&& family.HouseNumber==chosenFamily.HouseNumber)
                    {
                        family.Adults.Add(toAdd);
                    }
                }
                familyFile.SaveChanges();

        }

        public void RemoveAdult(int ID)
        {
            Adult toRemove;
            foreach (var family in familyFile.Families)
            {
                toRemove = family.Adults.FirstOrDefault(a => a.Id == ID);

                if (toRemove != null)
                {
                    family.Adults.Remove(toRemove);
                }
            }
            familyFile.SaveChanges();
        }

        public void RemoveFamily(string streetName, int houseNumber)
        {
            Family toRemove;
            toRemove = familyFile.Families.FirstOrDefault(f =>
                f.StreetName.Equals(streetName) && f.HouseNumber == houseNumber);
            if (toRemove!= null)
            {
                familyFile.Families.Remove(toRemove);
            }
            familyFile.SaveChanges();
        }

        public void Update(Adult adult)
        {
            throw new System.NotImplementedException();
        }

        public Adult GetAdult(int id)
        {
            foreach (var family in familyFile.Families)
            {
                foreach (var adult in adults)
                {
                    if (adult.Id==id)
                    {
                        return adult;
                    }
                }
               
            }
            return null;
        }

        public Family GetFamily(string streetName, int houseNumber)
        {
            foreach (var family in familyFile.Families)
            {
                if (streetName.Equals(family.StreetName) && houseNumber==family.HouseNumber)
                {
                    return family;
                }
            }
            return null;
        }
        
    }
}