using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Assignment02_WebAPI.Models;

namespace Assignment02_WebAPI.Persistence
{
    public class FileContext
    {
        public IList<Family> Families { get; private set; }

        private readonly string familiesFile = "D:\\Dokumenter D\\Git\\DNP1_Assignments\\Assignments\\Assignment02\\Assignment02_WebAPI\\families.json";
       

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