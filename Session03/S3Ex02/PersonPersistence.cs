using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace S3Ex02
{
    public class PersonPersistence
    {
        public void StoreObjects(List<Person> persons)
        {
            String ObjAsJSON = JsonSerializer.Serialize(persons,new JsonSerializerOptions()
            {
                WriteIndented = true
            });
            using (StreamWriter sw = new StreamWriter("MyPersons.txt"))
            {
                sw.WriteLine(ObjAsJSON);
            }
        }

        public string ReadObject(string fileName)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line=sr.ReadLine())!= null)
                {
                    sb.AppendLine(line);
                }
            }
            return sb.ToString();
            
        }
        
    }
}