//1.Implement a Basic Inheritance Hierarchy
//Time: 10 mins
//Create a base class `Vehicle` with properties `Brand` and `Speed`. Derive two classes `Car` and `Bike` from `Vehicle`. Add a method `DisplayInfo()` in `Vehicle` that should be accessible in the derived classes.

public class Vehicle
{
    public string? VehicleBrand { get; set; }
    public int VehicleSpeed { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {VehicleBrand}, Speed: {VehicleSpeed}");
    }
}

public class Car : Vehicle
{
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("This is a car.");
    }
}

public class Bike : Vehicle
{
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("This is a bike.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Car Brand:");
        string? carBrand = Console.ReadLine();
        Console.WriteLine("Enter Car Speed:");
        int carSpeed = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Bike Brand:");
        string? bikeBrand = Console.ReadLine();
        Console.WriteLine("Enter Bike Speed:");
        int bikeSpeed = int.Parse(Console.ReadLine());

        Car car = new Car { VehicleBrand = carBrand, VehicleSpeed = carSpeed };
        Bike bike = new Bike { VehicleBrand = bikeBrand, VehicleSpeed = bikeSpeed };

        car.DisplayInfo();
        bike.DisplayInfo();
    }
}
