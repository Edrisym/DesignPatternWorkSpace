namespace DesignPattern.Builder.Pizza.Interfaces;

public interface IPizzaToppingBuilder
{
    IPizzaToppingBuilder HasExtraCheese(bool hasExtraCheese);
    IPizzaToppingBuilder AddMeat(int slices);
    IPizzaToppingBuilder AddVegetables(string[] vegetables);
    IPizzaToppingBuilder HasPineapples(bool hasPineapple);
    IPizzaToppingBuilder HasExtraSauce(bool hasExtraSauce);
    IPizzaToppingBuilder IsSpicy(bool isSpicy);
    Pizza MakePizza();
}