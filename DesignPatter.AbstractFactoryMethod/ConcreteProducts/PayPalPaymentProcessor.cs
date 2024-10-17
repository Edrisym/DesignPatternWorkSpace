namespace DesignPatter.AbstractFactoryMethod.ConcreteProducts;

public class PayPalPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount) => Console.WriteLine($"Processing ${amount} payment via PayPal.");
}