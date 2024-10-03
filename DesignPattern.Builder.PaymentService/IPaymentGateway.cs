namespace DesignPattern.Builder.PaymentService;

public interface IPaymentGateway
{
    IPaymentGateway GatewayName(string gatewayName);
    IPaymentGateway Currency(string currency);
    IPaymentGateway Amount(decimal amount);
    IPaymentGateway PaymentMethod(string paymentMethod);
    IPaymentGateway WebhookUrl(string url);
    IPaymentGateway TransactionFee(decimal fee);

    PaymentGateway CreateGateway();
}