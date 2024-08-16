using DesignPattern.FactoryMethod;

MobileAppCreator mobileAppCreator = new MobileAppCreator();
var software = mobileAppCreator.CreateProduct();
Console.WriteLine(software);
Console.Read();