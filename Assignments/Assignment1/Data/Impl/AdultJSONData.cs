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
    public class AdultJSONData : IAdultData
    {
        private FileContext familyFile;
        IList<Adult> adults = new List<Adult>();
        IList<Child> children = new List<Child>();

        public AdultJSONData(FileContext familyFile)
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
            familyFile.Families.Add(family);
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

        public void Update(Adult adult)
        {
            throw new System.NotImplementedException();
        }

        public Adult Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}