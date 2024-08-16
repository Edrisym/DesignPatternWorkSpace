namespace DesignPattern.FactoryMethod;

public abstract class SoftwareCreator
{
    public abstract Software CreateProduct();

    public void SomeOperation()
    {
        Software software = CreateProduct();
        software.Develop();
    }
}