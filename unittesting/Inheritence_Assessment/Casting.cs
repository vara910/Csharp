

//8.Upcasting and Downcasting
//Time: 15 mins
//Create a base class `Person` and derive a class `Student`. Create an object of `Student`, upcast it to `Person`, and then downcast it back to `Student`. Demonstrate how type casting works

public class Person
{
    public string Name { get; set; }
}

public class Student : Person
{
    public int StudentId { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create a Student object
        Student student = new Student { Name = "John Doe", StudentId = 12345 };

        // Upcast Student to Person
        Person person = student;
        Console.WriteLine($"Upcasted to Person: Name = {person.Name}");

        // Downcast Person back to Student
        if (person is Student downcastedStudent)
        {
            Console.WriteLine($"Downcasted back to Student: Name = {downcastedStudent.Name}, StudentId = {downcastedStudent.StudentId}");
        }
        else
        {
            Console.WriteLine("Downcasting failed.");
        }
    }
}
