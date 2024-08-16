namespace DesignPattern.Builder.ConcreteBuilders;

public class SmartphoneBuilder : ISmartphoneBuilder
{
    private Smartphone _smartphone = new();

    public ISmartphoneBuilder BuildBrand(string brandName)
    {
        _smartphone.BrandName = brandName;
        return this;
    }

    public ISmartphoneBuilder BuildScreen(bool hasOLED)
    {
        _smartphone.HasScreenOLED = hasOLED;
        return this;
    }

    public ISmartphoneBuilder BuildBattery(string batteryCapacity)
    {
        _smartphone.Battery = batteryCapacity;
        return this;
    }

    public ISmartphoneBuilder BuildCamera(int numberOfCameras)
    {
        _smartphone.NumberOfCamera = numberOfCameras;
        return this;
    }

    public ISmartphoneBuilder BuildAndroidOS(bool isAndroid)
    {
        _smartphone.IsIOS = isAndroid;
        return this;
    }

    public ISmartphoneBuilder BuildWaterProof(bool isWaterProof)
    {
        _smartphone.IsWaterProof = isWaterProof;
        return this;
    }

    public Smartphone GetSmartphone()
    {
        return _smartphone;
    }

    public SmartphoneBuilder Reset()
    {
        _smartphone = new Smartphone();
        return this;
    }
}