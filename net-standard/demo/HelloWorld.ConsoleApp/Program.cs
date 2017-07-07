using System;

namespace HelloWorld.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine();

            string hello = name;
            Console.WriteLine(hello);

            Console.WriteLine();
        }
    }
}
