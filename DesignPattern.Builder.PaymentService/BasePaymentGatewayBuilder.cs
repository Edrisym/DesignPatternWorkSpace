namespace DesignPattern.Builder.PaymentService;

public abstract class BasePaymentGatewayBuilder
{
    public abstract BasePaymentGatewayBuilder GatewayName(string gatewayName);
    public abstract BasePaymentGatewayBuilder Currency(string currency);
    public abstract BasePaymentGatewayBuilder Amount(decimal amount);
    public abstract BasePaymentGatewayBuilder PaymentMethod(string paymentMethod);
    public abstract BasePaymentGatewayBuilder WebhookUrl(string url);
    public abstract BasePaymentGatewayBuilder TransactionFee();

    public abstract PaymentGateway CreateGateway();
}