namespace DesignPatter.AbstractFactoryMethod.ConcreteFactory;

public class PayPalPaymentGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentProcessor CreatePaymentProcessor() => new PayPalPaymentProcessor();
    public IRefundProcessor CreateRefundProcessor() => new PayPalRefundProcessor();
}