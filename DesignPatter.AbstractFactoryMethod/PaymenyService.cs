namespace DesignPatter.AbstractFactoryMethod;

public class PaymentService(IPaymentGatewayFactory factory)
{
    private readonly IPaymentProcessor _paymentProcessor = factory.CreatePaymentProcessor();
    private readonly IRefundProcessor _refundProcessor = factory.CreateRefundProcessor();

    public void MakePayment(decimal amount)
    {
        _paymentProcessor.ProcessPayment(amount);
    }

    public void RefundPayment(decimal amount)
    {
        _refundProcessor.ProcessRefund(amount);
    }
}