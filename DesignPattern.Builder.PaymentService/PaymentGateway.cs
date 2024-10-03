using System.Text;

namespace DesignPattern.Builder.PaymentService;

public class PaymentGateway
{
    public string Name { get; set; }
    public string Currency { get; set; }
    public decimal Amount { get; set; }
    public string SupportedPaymentMethod { get; set; }
    public string WebhookUrl { get; set; }
    public decimal TransactionFee { get; set; }

    public override string ToString()
    {
        var text = $"Payment Gateway: {Name}\n" +
                   $"Currency: {Currency}\n" +
                   $"Amount: {Amount:C2} {Currency}\n" +
                   $"Transaction Fee: {TransactionFee:P2}\n" +
                   $"Supported Payment Methods: {SupportedPaymentMethod}\n" +
                   $"Webhook URL: {WebhookUrl}\n" +
                   $"Total Charge (Amount + Fee): {(Amount + (Amount * TransactionFee)):C2} {Currency}\n" +
                   $"Processing Status: {ProcessPaymentResult()}";
        return text;
    }

    private string ProcessPaymentResult()
    {
        if (Amount > 0 && !string.IsNullOrEmpty(SupportedPaymentMethod))
        {
            return "Payment processed successfully.";
        }

        return "Payment failed. Invalid amount or payment method.";
    }
}

public enum EnumPaymentMethods
{
    CreditCard = 1,
    DebitCard = 2,
    ApplePay = 3,
    GooglePay = 4
}