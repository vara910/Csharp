//Constructor Chaining in Inheritance
//Time: 15 mins
//Create a class `Employee` with properties `Name` and `Salary`. Derive a class `Manager` that has an additional property `Bonus`. Use constructor chaining to initialize the properties from the base class.

public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }
}

public class Manager : Employee
{
    public decimal Bonus { get; set; }

    public Manager(string name, decimal salary, decimal bonus)
        : base(name, salary)
    {
        Bonus = bonus;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Salary: ");
        decimal salary = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter Bonus: ");
        decimal bonus = Convert.ToDecimal(Console.ReadLine());

        Manager manager = new Manager(name, salary, bonus);
        Console.WriteLine($"Name: {manager.Name}, Salary: {manager.Salary}, Bonus: {manager.Bonus}");
    }
}
