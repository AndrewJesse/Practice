using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;

namespace JsonReaderApp
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = "ContactInformation.json";
            string jsonContent = File.ReadAllText(jsonFilePath);

            List<Person> people = JsonSerializer.Deserialize<List<Person>>(jsonContent);

            Console.WriteLine("List of people:");
            Console.WriteLine("---------------------");

            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Name}");
                Console.WriteLine($"Age: {person.Age}");
                Console.WriteLine($"Email: {person.Email}");
                Console.WriteLine("---------------------");
            }
        }
    }
}
