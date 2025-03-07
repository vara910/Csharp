//. Interface vs Inheritance in C#
//Time: 15 mins
//Create an interface `IMovable` with a method `Move()`. Implement this interface in a `Robot` class. Also, create a base class `Machine` with a method `Start()`. Have `Robot` inherit from `Machine` and implement `IMovable`.

public interface IMovable
{
    void Move();
}

public class Machine
{
    public void Start()
    {
        Console.WriteLine("Machine starting...");
    }
}

public class Robot : Machine, IMovable
{
    public void Move()
    {
        Console.WriteLine("Robot moving...");
    }
}
using System;

public interface IMovable
{
    void Move();
}

public class Machine
{
    public void Start()
    {
        Console.WriteLine("Machine starting...");
    }
}

public class Robot : Machine, IMovable
{
    public void Move()
    {
        Console.WriteLine("Robot moving...");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Machine machine = new Machine();
        machine.Start();

        IMovable robot = new Robot();
        robot.Move();
    }
}
