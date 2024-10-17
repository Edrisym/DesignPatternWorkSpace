namespace DesignPatter.AbstractFactoryMethod.ConcreteFactory;

public class DigiPayPaymentGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentProcessor CreatePaymentProcessor() => new DigiPayPaymentProcessor();
    public IRefundProcessor CreateRefundProcessor() => new DigiPayRefundProcessor();
}