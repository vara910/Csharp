//7.Multiple Inheritance Using Interfaces
//Time: 15 mins
//Create two interfaces `IFlyable` and `ISwimmable` with methods `Fly()` and `Swim()`, respectively. Implement these interfaces in a class `Duck` to exhibit both behaviors.

interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

class Duck : IFlyable, ISwimmable
{
    public void Fly()
    {
        Console.WriteLine("The duck is flying.");
    }

    public void Swim()
    {
        Console.WriteLine("The duck is swimming.");
    }
}

class Program23
{
    static void Main(string[] args)
    {
        Duck duck = new Duck();

        Console.WriteLine("Enter 'fly' to make the duck fly or 'swim' to make the duck swim:");
        string input = Console.ReadLine().ToLower();

        if (input == "fly")
        {
            duck.Fly();
        }
        else if (input == "swim")
        {
            duck.Swim();
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
