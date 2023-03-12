using System;

namespace MethodToGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            CallMethod<int>(5, Increment);
        }
        static int Increment(int n)
        {
            return n + 1;
        }
        public static void CallMethod<T>(T arg, Func<T, T> method)
        {
            T result = method(arg);
            Console.WriteLine(result);
        }

    }
}
