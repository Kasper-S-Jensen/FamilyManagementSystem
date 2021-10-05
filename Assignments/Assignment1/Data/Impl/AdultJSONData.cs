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
            foreach (var family in familyFile.Families)
            {
                foreach (var adult in family.Adults)
                {
                    adults.Add(adult);
                }
            }

            return adults;
        }

        public IList<Child> GetChildren()
        {
            Console.WriteLine("inside get children");
            foreach (var family in familyFile.Families)
            {
                Console.WriteLine("inside first loop");
                foreach (var child in family.Children)
                {
                    Console.WriteLine(child.FirstName);
                    Console.WriteLine("inside inner loop");
                    children.Add(child);
                    
                }
            }

            foreach (var VARIABLE in children)
            {
                Console.WriteLine(VARIABLE.FirstName + "HEEEEEEEEEEEEEEEEEEEEEEEEEEEEEY");
            }
            return children;
        }

        public void AddFamily(Family family)
        {
          //  int max = adults.Max(adult => adult.Id);
          //  adult.Id = (++max);
          
           familyFile.Families.Add(family);
           familyFile.SaveChanges();
        }

        public void RemoveAdult(int ID)
        {
            Adult toRemove = adults.First(a => a.Id == ID);
            adults.Remove(toRemove);
          
            
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