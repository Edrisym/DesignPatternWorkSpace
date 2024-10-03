using DesignPattern.Builder.PaymentService;

var builder = new PaymentGatewayBuilder();
var director = new PaymentServiceDirector(builder);

var zarrinpal = director.OpenZarinpalGateway();

Console.WriteLine(zarrinpal);