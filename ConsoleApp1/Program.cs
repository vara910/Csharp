using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"The square of {number} is {number * number}.");
        }
    }
}
