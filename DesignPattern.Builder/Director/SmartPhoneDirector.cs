using DesignPattern.Builder.Interfaces;

namespace DesignPattern.Builder.Director;

public class SmartPhoneDirector
{
    private readonly ISmartPhoneBuilder _builder;

    public SmartPhoneDirector(ISmartPhoneBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructSmartphone()
    {
        _builder.BuildBrand();
        _builder.BuildScreen();
        _builder.BuildBattery();
        _builder.BuildCamera();
        _builder.BuildOS();
        _builder.BuildWaterProof();
    }
}