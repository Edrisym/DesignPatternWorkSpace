namespace DesignPattern.FactoryMethod;
public class WebApplicationCreator : SoftwareCreator
{
    public override Software CreateProduct() => new WebApplication();
}