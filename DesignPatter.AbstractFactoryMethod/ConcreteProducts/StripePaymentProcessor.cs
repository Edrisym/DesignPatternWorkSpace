namespace DesignPatter.AbstractFactoryMethod.ConcreteProducts;

public class StripePaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing ${amount} payment via Stripe.");
    }
}