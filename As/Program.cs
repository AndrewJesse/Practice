using System;

namespace As
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] array = new object[] { "hello", 123, true, 4.5 };

            for (int i = 0; i < array.Length; i++)
            {
                string str = array[i] as string;
                if (str != null)
                {
                    Console.WriteLine("Element " + i + " is a string: " + str);
                }
                else
                {
                    Console.WriteLine("Element " + i + " is not a string.");
                }
            }
        }
    }
}
