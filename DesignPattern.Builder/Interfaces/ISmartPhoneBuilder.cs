namespace DesignPattern.Builder.Interfaces;

public interface ISmartphoneBuilder
{
    ISmartphoneBuilder BuildBrand(string brandName);
    ISmartphoneBuilder BuildScreen(bool hasOLED);
    ISmartphoneBuilder BuildBattery(string batteryCapacity);
    ISmartphoneBuilder BuildCamera(int numberOfCameras);
    ISmartphoneBuilder BuildAndroidOS(bool isAndroid);
    ISmartphoneBuilder BuildWaterProof(bool isWaterProof);
    Smartphone GetSmartphone();
}