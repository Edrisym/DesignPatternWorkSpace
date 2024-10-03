namespace DesignPattern.Builder.PaymentService;

public class PaymentGatewayBuilder : BasePaymentGatewayBuilder
{
    private PaymentGateway _gateway = new();

    public override BasePaymentGatewayBuilder GatewayName(string gatewayName)
    {
        _gateway.Name = gatewayName;
        return this;
    }

    public override BasePaymentGatewayBuilder Currency(string currency)
    {
        _gateway.Currency = currency;
        return this;
    }

    public override BasePaymentGatewayBuilder Amount(decimal amount)
    {
        _gateway.Amount = amount;
        return this;
    }

    public override BasePaymentGatewayBuilder PaymentMethod(string paymentMethod)
    {
        _gateway.SupportedPaymentMethod = paymentMethod;
        return this;
    }

    public override BasePaymentGatewayBuilder WebhookUrl(string url)
    {
        _gateway.WebhookUrl = url;
        return this;
    }

    public override BasePaymentGatewayBuilder TransactionFee()
    {
        _gateway.TransactionFee = CalculateTransactionFee(_gateway.Amount);
        return this;
    }

    public override PaymentGateway CreateGateway()
    {
        return _gateway;
    }

    public PaymentGatewayBuilder Reset()
    {
        _gateway = new();
        return this;
    }

    private decimal CalculateTransactionFee(decimal amount)
    {
        return amount * 0.10m;
    }
}