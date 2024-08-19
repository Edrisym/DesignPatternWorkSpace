using DesignPattern.FactoryMethod.Abstraction;

namespace DesignPattern.FactoryMethod.Products;

public class WebApplication : ISoftwareProduct
{
    public void Develop()
    {
        Console.WriteLine("WebApplication software is running...");
    }
}