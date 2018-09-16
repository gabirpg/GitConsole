using System;

namespace GitConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Git!");
            Console.WriteLine("Hello Git modified1!");
            Console.WriteLine("Hello Git modified2!");
            Console.WriteLine("Diff between stages and commited");

            Console.WriteLine("Commit for a new annotated tag!");

            Console.WriteLine("Commit for a new lightway tag!");

            Console.WriteLine("Commit to remove some unused namespaces on branch testing!");

            Console.ReadLine();
        }
    }
}
