using DesignPattern.FactoryMethod.Abstraction;

namespace DesignPattern.FactoryMethod.Products;

public class MobileApplication : ISoftwareProduct
{
    public void Develop()
    {
        Console.WriteLine("MobileApplication software is running...");
    }
}