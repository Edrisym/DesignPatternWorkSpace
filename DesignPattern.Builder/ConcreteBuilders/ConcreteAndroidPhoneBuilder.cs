using DesignPattern.Builder.Interfaces;
using DesignPattern.Builder.Models;

namespace DesignPattern.Builder.ConcreteBuilders;

public class ConcreteAndroidPhoneBuilder : ISmartPhoneBuilder
{
    private Smartphone smartphone = new();
    
    public void BuildBrand()
    {
        smartphone.BrandName = "Xiaomi";
    }

    public void BuildScreen()
    {
        smartphone.Screen = "AMOLED Display";
    }

    public void BuildBattery()
    {
        smartphone.Battery = "4500mAh";
    }

    public void BuildCamera()
    {
        smartphone.Camera = "Quad 64MP Camera";
    }

    public void BuildOS()
    {
        smartphone.OS = "Android with Custom UI";
    }

    public void BuildWaterProof()
    {
        smartphone.WaterProof = "IP67 Waterproof";
    }

    public Smartphone GetResult()
    {
        return smartphone;
    }
}