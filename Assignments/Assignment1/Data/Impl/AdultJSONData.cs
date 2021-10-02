using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Assignment1.Pages;
using Models;
using Assignment1.Persistence;

namespace Assignment1.Data.Impl
{
    public class AdultJSONData : IAdultData
    {
        private FileContext adultFile;
        private IList<Adult> _adults;
        private string fileName = "adults.json";
        public AdultJSONData()
        {
            adultFile = new FileContext();
            if (!File.Exists(fileName))
            {
                adultFile.SaveChanges();
            }
            else
            {
                string content = File.ReadAllText(fileName);
                _adults = JsonSerializer.Deserialize<List<Adult>>(content);
            }
        }

        public IList<Adult> GetAdults()
        {
            List<Adult> adultlist = new List<Adult>(_adults);
            return adultlist;
        }

        public void AddAdult(Adult adult)
        {
            int max = _adults.Max(adult => adult.Id);
            adult.Id = (++max);
            _adults.Add(adult);
            
            adultFile.SaveChanges();
        }

        public void RemoveAdult(int adultId)
        {
            Adult toRemove = _adults.First(a => a.Id == adultId);
            _adults.Remove(toRemove);
            
           adultFile.SaveChanges();
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