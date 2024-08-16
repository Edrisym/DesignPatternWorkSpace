using DesignPattern.FactoryMethod;

MobileAppCreator mobileAppCreator = new MobileAppCreator();
var softwareProduct = mobileAppCreator.CreateProduct();


Console.WriteLine(softwareProduct);

Console.Read();