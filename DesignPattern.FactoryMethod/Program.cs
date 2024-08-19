using DesignPattern.FactoryMethod.ConcreteCreators;

MobileAppCreator mobileAppCreator = new MobileAppCreator();
mobileAppCreator.SomeOperation();


WebApplicationCreator webAppCreator = new WebApplicationCreator();
webAppCreator.SomeOperation();

Console.Read();