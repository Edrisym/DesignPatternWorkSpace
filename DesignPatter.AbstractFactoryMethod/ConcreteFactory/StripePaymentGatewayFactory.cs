namespace DesignPatter.AbstractFactoryMethod.ConcreteFactory;

public class StripePaymentGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentProcessor CreatePaymentProcessor() => new StripePaymentProcessor();
    public IRefundProcessor CreateRefundProcessor() => new StripeRefundProcessor();
}