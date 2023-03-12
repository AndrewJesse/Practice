using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // 1) List of Product classes
        var products = new List<Product> {
            new Product { Id = 1, Name = "Shirt", Price = 10.0 },
            new Product { Id = 2, Name = "Pants", Price = 20.0 },
            new Product { Id = 2, Name = "Hat", Price = 5.0 },
            new Product { Id = 2, Name = "Gloves", Price = 5.0 }
        };

        DisplayProducts(products);
    }

    public static void DisplayProducts(IEnumerable<Product> products)
    {
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name}: {product.Price:C}");
        }
    }
}

public class Product
{
    // Define properties of a product
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}
