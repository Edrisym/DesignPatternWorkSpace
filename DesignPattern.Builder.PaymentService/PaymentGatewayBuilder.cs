namespace DesignPattern.Builder.PaymentService;

public class PaymentGatewayBuilder : BasePaymentGatewayBuilder
{
    private PaymentGateway _gateway = new();

    protected override BasePaymentGatewayBuilder GatewayName(string gatewayName)
    {
        _gateway.Name = gatewayName;
        return this;
    }

    protected override BasePaymentGatewayBuilder Currency(string currency)
    {
        _gateway.Currency = currency;
        return this;
    }

    protected override BasePaymentGatewayBuilder Amount(decimal amount)
    {
        _gateway.Amount = amount;
        return this;
    }

    protected override BasePaymentGatewayBuilder PaymentMethod(string paymentMethod)
    {
        _gateway.SupportedPaymentMethod = paymentMethod;
        return this;
    }

    protected override BasePaymentGatewayBuilder WebhookUrl(string url)
    {
        _gateway.WebhookUrl = url;
        return this;
    }

    protected override BasePaymentGatewayBuilder TransactionFee(decimal fee)
    {
        _gateway.TransactionFee = fee;
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
}