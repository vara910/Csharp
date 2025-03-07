using System;
public class Practice
{
    public static void Main()
    {
        Console.WriteLine("Enter a number:");
        String input = Console.ReadLine();
        int num = int.Parse(input);
        //Console.WriteLine(num);
        Console.WriteLine("number you entered: " + input);
    }
}