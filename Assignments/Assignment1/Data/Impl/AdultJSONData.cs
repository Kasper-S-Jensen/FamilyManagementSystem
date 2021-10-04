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
           
            Console.WriteLine("inside get adults");
            foreach (var VARIABLE in familyFile.Families)
            {
                foreach (var adult in VARIABLE.Adults)
                {
                    adults.Add(adult);
                }
            }

            return adults;
        }

        public IList<Child> GetChildren()
        {
            Console.WriteLine("inside get adults");
            foreach (var VARIABLE in familyFile.Families)
            {
                foreach (var child in VARIABLE.Children)
                {
                    children.Add(child);
                }
            }

            return children;
        }

        public void AddFamily(Family family)
        {
          //  int max = _adults.Max(adult => adult.Id);
           // adult.Id = (++max);
          
           familyFile.Families.Add(family);
           familyFile.SaveChanges();
        }

        public void RemoveFamily(int houseNumber, string StreetName)
        {
            /*Adult toRemove = adults.First(a => a.Id == adultId);
            adults.Remove(toRemove);
            
           familyFile.SaveChanges();*/
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