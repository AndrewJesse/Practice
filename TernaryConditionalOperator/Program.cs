using System;

namespace TernaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");
            int age;
            bool isValid = int.TryParse(Console.ReadLine(), out age);

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            string ageCategory = age >= 18 ? "adult" : "minor";
            Console.WriteLine($"You are an {ageCategory}.");
        }
    }
}
