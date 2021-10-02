using System;
using System.Collections.Generic;
using System.Text.Json;

namespace S3Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Michael = new Person("Michael", "Jensen", 40, 1.80, false, 'M',
                new string[] {"football", "Fishing", "Drawing"});
            Person Lars = new Person("Lars", "Hansen", 50, 2.80, true, 'M',
                new string[] {"football", "diving", "crying"});
            Person Cecilie = new Person("Cecilie", "Bomsen", 20, 1.50, true, 'F',
                new string[] {"skating", "flirting", "dancing"});

            List<Person> list = new List<Person>();
            list.Add(Michael);
            list.Add(Lars);
            list.Add(Cecilie);

            PersonPersistence persistence = new PersonPersistence();
            persistence.StoreObjects(list);
            var readObject = persistence.ReadObject("MyPersons.txt");
            List<Person> BackAgain = JsonSerializer.Deserialize<List<Person>>(readObject);
          
            foreach (var person in BackAgain)
            {
                Console.WriteLine(person);
            }
        }
    }
}