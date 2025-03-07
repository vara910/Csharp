//Method Overriding and Base Keyword
//Time: 12 mins
//Modify the `DisplayInfo()` method in `Vehicle` to print `Brand` and `Speed`. Override this method in `Car` and `Bike` to include additional specific information. Ensure the base class method is called using `base.DisplayInfo()`.

public class Vehicle1
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed}");
    }
}

public class Car1 : Vehicle1
{
    public int NumberOfDoors { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Number of Doors: {NumberOfDoors}");
    }
}

public class Bike1 : Vehicle1
{
    public bool HasCarrier { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has Carrier: {HasCarrier}");
    }
}
class Program1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Car Brand:");
        string? carBrand = Console.ReadLine();
        Console.WriteLine("Enter Car Speed:");
        int carSpeed = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Number of Doors for Car:");
        int numberOfDoors = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Bike Brand:");
        string? bikeBrand = Console.ReadLine();
        Console.WriteLine("Enter Bike Speed:");
        int bikeSpeed = int.Parse(Console.ReadLine());
        Console.WriteLine("Does the Bike have a Carrier? (true/false):");
        bool hasCarrier = bool.Parse(Console.ReadLine());

        Car1 car = new Car1 { Brand = carBrand, Speed = carSpeed, NumberOfDoors = numberOfDoors };
        Bike1 bike = new Bike1 { Brand = bikeBrand, Speed = bikeSpeed, HasCarrier = hasCarrier };

        car.DisplayInfo();
        bike.DisplayInfo();
    }
}
