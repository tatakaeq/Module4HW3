using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var str1 = "4";
            var str2 = "5";
            Console.WriteLine(Int32.Parse(str1) + Int32.Parse(str2));
        }
    }
}