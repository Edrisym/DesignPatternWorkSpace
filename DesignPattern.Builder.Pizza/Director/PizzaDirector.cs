using DesignPattern.Builder.Pizza.Interfaces;

namespace DesignPattern.Builder.Pizza.Director;

public class PizzaDirector
{
    private readonly IPizzaToppingBuilder _builder;

    public PizzaDirector(IPizzaToppingBuilder builder)
    {
        _builder = builder;
    }

    public Pizza MakePizzaOrder_1()
    {
        return _builder.HasPineapples(false) // Nice choice 😌
            .HasExtraSauce(true)
            .HasExtraCheese(false)
            .AddMeat(15)
            .AddVegetables(["onion", "mushroom", "tomatoes"])
            .IsSpicy(true)
            .MakePizza();
    }

    public Pizza MakePizzaOrder_2()
    {
        return _builder.HasPineapples(true) // Oh please don't do it 😔
            .HasExtraSauce(true)
            .HasExtraCheese(false)
            .AddMeat(0)
            .AddVegetables(["olive", "spinach", "broccoli", "bell peppers"])
            .IsSpicy(false)
            .MakePizza();
    }
}