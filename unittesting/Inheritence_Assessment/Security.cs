//10.Prevent Inheritance Using Sealed Class
//Time: 10 mins
//Create a `sealed` class `SecuritySystem` with a method `AuthenticateUser()`. Try to derive a class from it and observe the compiler error. Explain why `sealed` is useful in real - world applications.

sealed class SecuritySystem
{
    public void AuthenticateUser(string username, string password)
    {
        // Simulate authentication logic
        if (username == "varaprasad" && password == "vara123")
        {
            Console.WriteLine("Authentication successful.");
        }
        else
        {
            Console.WriteLine("Authentication failed.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SecuritySystem securitySystem = new SecuritySystem();

        Console.WriteLine("Enter username:");
        string? username = Console.ReadLine();

        Console.WriteLine("Enter password:");
        string? password = Console.ReadLine();

        securitySystem.AuthenticateUser(username, password);
    }
}
