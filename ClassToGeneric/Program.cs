using System;

public class Program
{
    public static void Main(string[] args)
    {
        var productA = new Product { Id = 1, Name = "Product A", Price = 10.0 };
        DisplayObjectInfo<Product>(productA);
    }

    public static void DisplayObjectInfo<T>(T obj)
    {
        Console.WriteLine("Type: {0}", typeof(T));
        Console.WriteLine("Value: {0}", obj);
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}
