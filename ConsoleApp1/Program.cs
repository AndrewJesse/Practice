using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Field or Objects
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            string[] stringArray = { "1", "2", "3" };
            
            // 2) To Generic
            displayElements(doubleArray);
            displayElements(stringArray);

        }
        public static void displayElements<Generic>(Generic[] array)
        {
            // 3 Simple foreach loop over an array but method can take Generic
            foreach (Generic item in array)
            {
                Console.Write(item);
            }
        }
    }
}
