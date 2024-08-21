using DesignPattern.Builder.Pizza.ConcreteBuilders;
using DesignPattern.Builder.Pizza.Director;

var builder = new PizzaToppingBuilder();
var director = new PizzaDirector(builder);

var pizz_Order_1 = director.MakePizzaOrder_1();
const string line = "--------------------------------------------------------------------------------------------------------------------";
Console.WriteLine(line);
Console.WriteLine(pizz_Order_1);

builder.Reset();


var pizz_Order_2 = director.MakePizzaOrder_2();
Console.WriteLine(line);
Console.WriteLine(pizz_Order_2);

builder.Reset();

var customPizza = builder.HasPineapples(false) 
    .HasExtraSauce(true)
    .HasExtraCheese(false)
    .AddMeat(15)
    .AddVegetables(["onion", "mushroom", "tomatoes"])
    .IsSpicy(true)
    .MakePizza();

Console.WriteLine(line);
Console.WriteLine(customPizza);
Console.WriteLine(line);

Console.Read();