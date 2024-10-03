namespace DesignPattern.Builder.PaymentService;

public abstract class BasePaymentGatewayBuilder
{
    protected abstract BasePaymentGatewayBuilder GatewayName(string gatewayName);
    protected abstract BasePaymentGatewayBuilder Currency(string currency);
    protected abstract BasePaymentGatewayBuilder Amount(decimal amount);
    protected abstract BasePaymentGatewayBuilder PaymentMethod(string paymentMethod);
    protected abstract BasePaymentGatewayBuilder WebhookUrl(string url);
    protected abstract BasePaymentGatewayBuilder TransactionFee(decimal fee);

    public abstract PaymentGateway CreateGateway();
}