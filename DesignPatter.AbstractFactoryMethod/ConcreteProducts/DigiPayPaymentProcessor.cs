namespace DesignPatter.AbstractFactoryMethod.ConcreteProducts;

public class DigiPayPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing ${amount} payment via DigiPay.");
    }
}