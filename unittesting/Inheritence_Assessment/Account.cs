//using System.Security.Principal;

//6.Sealed Class and Methods
//Time: 12 mins
//Create a base class `Account` with a virtual method `CalculateInterest()`. Derive a class `SavingsAccount` and override `CalculateInterest()`. Now, prevent further overriding by marking it as `sealed`.
public class Account
{
    public virtual double CalculateInterest(double balance)
    {
        // Default interest calculation
        return balance * 0.01;
    }
}

public class SavingsAccount : Account
{
    public sealed override double CalculateInterest(double balance)
    {
        // Specific interest calculation for savings account
        return balance * 0.03;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter balance for Account: ");
        double accountBalance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter balance for Savings Account: ");
        double savingsAccountBalance = Convert.ToDouble(Console.ReadLine());

        Account account = new Account();
        SavingsAccount savingsAccount = new SavingsAccount();

        double accountInterest = account.CalculateInterest(accountBalance);
        double savingsAccountInterest = savingsAccount.CalculateInterest(savingsAccountBalance);

        Console.WriteLine($"Account Interest: {accountInterest}");
        Console.WriteLine($"Savings Account Interest: {savingsAccountInterest}");
    }
}
