namespace DesignPatter.AbstractFactoryMethod.ConcreteProducts;

public class DigiPayRefundProcessor : IRefundProcessor
{
    public void ProcessRefund(decimal amount) =>
        Console.WriteLine($"Processing ${amount} refund via DigiPay.");
}