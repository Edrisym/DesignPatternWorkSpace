namespace DesignPatter.AbstractFactoryMethod.AbstractFactory;

public interface IPaymentGatewayFactory
{
    IPaymentProcessor CreatePaymentProcessor();
    IRefundProcessor CreateRefundProcessor();
}