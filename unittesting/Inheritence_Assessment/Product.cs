using System;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public virtual decimal GetDiscountedPrice()
    {
        // No discount by default
        return Price;
    }
}

public class ElectronicProduct : Product
{
    public ElectronicProduct(string name, decimal price) : base(name, price) { }

    public override decimal GetDiscountedPrice()
    {
        // 10% discount for electronic products
        return Price * 0.9m;
    }
}

public class ClothingProduct : Product
{
    public ClothingProduct(string name, decimal price) : base(name, price) { }

    public override decimal GetDiscountedPrice()
    {
        // 20% discount for clothing products
        return Price * 0.8m;
    }
}

public class Program12
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter product type (Electronic/Clothing): ");
        string type = Console.ReadLine();

        Console.WriteLine("Enter product name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter product price: ");
        decimal price = decimal.Parse(Console.ReadLine());

        Product product;

        if (type.Equals("Electronic", StringComparison.OrdinalIgnoreCase))
        {
            product = new ElectronicProduct(name, price);
        }
        else if (type.Equals("Clothing", StringComparison.OrdinalIgnoreCase))
        {
            product = new ClothingProduct(name, price);
        }
        else
        {
            Console.WriteLine("Invalid product type.");
            return;
        }

        Console.WriteLine($"Product Name: {product.Name}");
        Console.WriteLine($"Original Price: {product.Price:C}");
        Console.WriteLine($"Discounted Price: {product.GetDiscountedPrice():C}");
    }
}
