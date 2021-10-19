using System;
using System.IO;
using System.Collections;

namespace P0
{
    class Program
    {
        public static void PrintTheSizeOfTheArray(int size)
        {
            Console.WriteLine(size);
        }
        public static string P0(string [] args, int test)
        {
            var sizeOfTheStringArray = args.Length;
            var localTest = test;
            Console.WriteLine(localTest);
            PrintTheSizeOfTheArray(sizeOfTheStringArray);
            return sizeOfTheStringArray.ToString();
        }
        // The Main function will run our program
        static void Main(string[] args)
        {
            Console.WriteLine("hello from Main()");
            int test = 5;
            int adding = test + 20;
            test = 99;
            P0(args, test);
            test = 3 + adding;
            Console.Write(test);
        }
    }
}
