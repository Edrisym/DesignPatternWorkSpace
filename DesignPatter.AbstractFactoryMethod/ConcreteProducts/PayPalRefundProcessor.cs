namespace DesignPatter.AbstractFactoryMethod.ConcreteProducts;

public class PayPalRefundProcessor : IRefundProcessor
{
    public void ProcessRefund(decimal amount)
    {
        Console.WriteLine($"Processing ${amount} refund via PayPal.");
    }
}