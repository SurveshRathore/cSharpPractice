using Newtonsoft.Json;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBasic
{
    public class ArrayListJson
    {
        public ArrayListJson() { }

        public void AddData(string fName, string lName, int age, string city)
        {
            List<Person> list = new List<Person>();
            Person person = new Person();
            person.FirstName = fName;
            person.LastName = lName;
            person.Age = age;
            person.City = city;
            list.Add(person);

            // serialize the list to JSON and write it to a file.
            string json = JsonConvert.SerializeObject(list);
            //File.WriteAllText("people.json", json);
            File.AppendAllText("people.json", json);



            Console.WriteLine(json);

            // Read the JSON data from the file
            string json2 = File.ReadAllText("people.json");

            // Deserialize the JSON data into an instance of your class
            Person person1 = System.Text.Json.JsonSerializer.Deserialize<Person>(json2);

            // Access the deserialized data
            Console.WriteLine($"Name: {person1.FirstName} {person1.LastName}, Age: {person1.Age}, City: {person1.City}");

           
        }

        public void GetJsonData()
        {
            string json = File.ReadAllText("people.json");

            // Deserialize the JSON to a list of Person objects
            List<Person> list = JsonConvert.DeserializeObject<List<Person>>(json);

            foreach(Person person in list ){
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}, City: {person.City}");
            }


        }
    }
}
