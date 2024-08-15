using DesignPattern.Builder.Models;

namespace DesignPattern.Builder.Interfaces;

public interface ISmartPhoneBuilder
{
    void BuildBrand();
    void BuildScreen();
    void BuildBattery();
    void BuildCamera();
    void BuildOS();
    void BuildWaterProof();
    Smartphone GetResult();
}