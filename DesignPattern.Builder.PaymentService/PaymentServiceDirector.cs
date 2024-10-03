namespace DesignPattern.Builder.PaymentService;

public class PaymentServiceDirector
{
    private readonly BasePaymentGatewayBuilder _builder;

    public PaymentServiceDirector(BasePaymentGatewayBuilder builder)
    {
        _builder = builder;
    }

    public PaymentGateway OpenZarinpalGateway()
    {
        return _builder.GatewayName("Zarinpal")
            .Amount(100)
            .TransactionFee()
            .Currency("USD")
            .PaymentMethod(Enum.GetName(EnumPaymentMethods.CreditCard)!)
            .WebhookUrl("https://Url")
            .CreateGateway();
    }
}