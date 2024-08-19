using DesignPattern.FactoryMethod.Abstraction;
using DesignPattern.FactoryMethod.Creator;
using DesignPattern.FactoryMethod.Products;

namespace DesignPattern.FactoryMethod.ConcreteCreators;
public class WebApplicationCreator : SoftwareCreator
{
    public override ISoftwareProduct CreateProduct() => new WebApplication();
}