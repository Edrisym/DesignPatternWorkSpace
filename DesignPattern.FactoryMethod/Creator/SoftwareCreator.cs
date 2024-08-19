using DesignPattern.FactoryMethod.Abstraction;

namespace DesignPattern.FactoryMethod.Creator;

public abstract class SoftwareCreator
{
    public abstract ISoftwareProduct CreateProduct();

    public void SomeOperation()
    {
        ISoftwareProduct software = CreateProduct();
        software.Develop();
    }
}