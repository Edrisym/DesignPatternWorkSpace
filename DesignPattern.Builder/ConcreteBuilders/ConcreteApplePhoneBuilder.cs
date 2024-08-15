using DesignPattern.Builder.Interfaces;
using DesignPattern.Builder.Models;

namespace DesignPattern.Builder.ConcreteBuilders;

public class ConcreteApplePhoneBuilder : ISmartPhoneBuilder
{
    private Smartphone smartphone = new ();

    public void BuildBrand()
    {
        smartphone.BrandName = "Apple";
    }

    public void BuildScreen()
    {
        smartphone.Screen = "Super Retina XDR Display";
    }

    public void BuildBattery()
    {
        smartphone.Battery = "3100mAh";
    }

    public void BuildCamera()
    {
        smartphone.Camera = "Dual 12MP Camera";
    }

    public void BuildOS()
    {
        smartphone.OS = "IOS";
    }

    public void BuildWaterProof()
    {
        smartphone.WaterProof = "IP68 Waterproof";
    }

    public Smartphone GetResult()
    {
        return smartphone;
    }
}