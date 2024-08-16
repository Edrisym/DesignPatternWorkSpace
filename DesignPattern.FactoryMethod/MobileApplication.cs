using System.Xml;

namespace DesignPattern.FactoryMethod;

public class MobileApplication : ISoftwareProduct
{
    public void Develop()
    {
        Console.WriteLine("This software is running...");
    }
}