using System;
using NetFrameworkLibrary;

namespace HelloWorld.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".NET Framework Console Application");
            Console.WriteLine();
            Console.WriteLine(StringProvider.GetHelloWorldString());
            Console.Read();
        }
    }
}
