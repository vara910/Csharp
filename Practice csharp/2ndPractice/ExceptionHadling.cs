using System;

namespace _2ndPractice
{
    class ExceptionHandling
    {
        public void ExampleExeption()
        {
            try
            {
                int num;
                Console.WriteLine("enter the number :");
                Console.ReadLine();
                int result = num / 0;
                Console.WriteLine(result);
                //return result;

            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Arithmetic exception caught: {ex.Message}");
            }
            //return result;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExceptionHandling eh = new ExceptionHandling();
            eh.ExampleExeption();
        }
    }
}
