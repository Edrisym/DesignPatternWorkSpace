namespace DesignPattern.FactoryMethod;

public class WebApplicationCreator : SoftwareCreator
{
    public override ISoftwareProduct CreateProduct()
    {
        return new WebApplication();
    }
}