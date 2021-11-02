using System;
using System.Collections.Generic;
using System.Linq;
using Assignment02_WebAPI.Models;
using Assignment02_WebAPI.Persistence;

namespace Assignment02_WebAPI.Data.Impl
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

        public void AddFamily(Family family)
        {
            
            foreach (var existingFamily in familyFile.Families)
            {
                if (existingFamily.StreetName.Equals(family.StreetName) && existingFamily.HouseNumber==family.HouseNumber)
                {
                    throw new Exception("Family already exists");
                }
                
            }
            familyFile.Families.Add(family);
            familyFile.SaveChanges();
           
           
        }

        public void AddAdult(Family family)
        {
           

            Adult toAdd= new Adult();
            foreach (var adult in family.Adults)
            {
                toAdd = adult;
            }
            
            
            Family chosenFamily = GetFamily(family.StreetName,family.HouseNumber);
            
                if (chosenFamily.Adults.Count==2)
                {
                    throw new Exception("Family already has max number of adults");
                }

                foreach (var excistingFamily in familyFile.Families)
                {
                    if (excistingFamily.StreetName.Equals(family.StreetName)&& excistingFamily.HouseNumber==family.HouseNumber)
                    {
                        excistingFamily.Adults.Add(toAdd);
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

        public void Update(Family family)
        {
            throw new NotImplementedException();
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
            throw new Exception("No such family exists");
        }
        
    }
}