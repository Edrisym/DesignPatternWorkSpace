namespace DesignPatter.AbstractFactoryMethod.ConcreteProducts;

public class StripeRefundProcessor : IRefundProcessor
{
    public void ProcessRefund(decimal amount) => Console.WriteLine($"Processing ${amount} refund via Stripe.");
}