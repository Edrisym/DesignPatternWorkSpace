namespace DesignPatter.AbstractFactoryMethod.AbstractProducts;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}