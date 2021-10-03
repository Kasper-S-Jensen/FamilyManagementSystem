using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Assignment1.Models;

namespace Assignment1.Persistence
{
    public class FileContext
    {
        public IList<Family> Families { get; private set; }

        private readonly string familiesFile = "C:\\Users\\kaspe\\OneDrive - ViaUC\\Diplomingenioer\\3.sem\\DNP\\Solutions\\DNP1\\Assignments\\Assignment1\\families.json";
       

        public FileContext()
        {
            Families = File.Exists(familiesFile) ? ReadData<Family>(familiesFile) : new List<Family>();
        }

        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(s))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        public void SaveChanges()
        {
            // storing families
            string jsonFamilies = JsonSerializer.Serialize(Families, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(familiesFile, false))
            {
                outputFile.Write(jsonFamilies);
            }
        }
    }
}