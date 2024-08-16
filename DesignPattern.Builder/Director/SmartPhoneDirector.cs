using DesignPattern.Builder.Interfaces;

namespace DesignPattern.Builder.Director;

public class SmartphoneDirector
{
    private readonly ISmartphoneBuilder _builder;

    public SmartphoneDirector(ISmartphoneBuilder builder)
    {
        _builder = builder;
    }

    public Smartphone ConstructApplePhone()
    {
        return _builder.BuildBrand("Apple")
            .BuildScreen(true)
            .BuildBattery("5100mAh")
            .BuildCamera(3)
            .BuildAndroidOS(false)
            .BuildWaterProof(true)
            .GetSmartphone();
    }
    
    public Smartphone ConstructAndroidPhone()
    {
        return _builder.BuildBrand("Xiaomi")
            .BuildScreen(false)
            .BuildBattery("4200mAh")
            .BuildCamera(2)
            .BuildAndroidOS(true)
            .BuildWaterProof(false)
            .GetSmartphone();
    }
    
}