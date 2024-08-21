using DesignPattern.Builder.Pizza.Interfaces;

namespace DesignPattern.Builder.Pizza.ConcreteBuilders;

public class PizzaToppingBuilder : IPizzaToppingBuilder
{
    private Pizza _pizza = new();

    public IPizzaToppingBuilder HasExtraCheese(bool hasExtraCheese)
    {
        _pizza.HasExtraCheese = hasExtraCheese;
        return this;
    }

    public IPizzaToppingBuilder AddMeat(int slices)
    {
        _pizza.MeatSlices = slices;
        return this;
    }

    public IPizzaToppingBuilder AddVegetables(string[] vegetables)
    {
        _pizza.Vegetables = vegetables;
        return this;
    }

    public IPizzaToppingBuilder HasPineapples(bool hasPineapple)
    {
        _pizza.HasPineapple = hasPineapple;
        return this;
    }

    public IPizzaToppingBuilder HasExtraSauce(bool hasExtraSauce)
    {
        _pizza.HasExtraSauce = hasExtraSauce;
        return this;
    }

    public IPizzaToppingBuilder IsSpicy(bool isSpicy)
    {
        _pizza.IsSpicy = isSpicy;
        return this;
    }

    public Pizza MakePizza()
    {
        return _pizza;
    }

    public PizzaToppingBuilder Reset()
    {
        _pizza = new Pizza();
        return this;
    }
}