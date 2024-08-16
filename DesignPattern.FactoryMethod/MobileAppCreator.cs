namespace DesignPattern.FactoryMethod;

public class MobileAppCreator : SoftwareCreator
{
    public override ISoftwareProduct CreateProduct() => new MobileApplication();
}