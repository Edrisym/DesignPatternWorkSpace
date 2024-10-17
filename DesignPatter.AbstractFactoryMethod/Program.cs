
IPaymentGatewayFactory stripeFactory = new StripePaymentGatewayFactory();
PaymentService stripeService = new PaymentService(stripeFactory);
stripeService.MakePayment(100.00m);
stripeService.RefundPayment(25.00m);

Console.WriteLine();

IPaymentGatewayFactory payPalFactory = new PayPalPaymentGatewayFactory();
PaymentService payPalService = new PaymentService(payPalFactory);
payPalService.MakePayment(150.00m);
payPalService.RefundPayment(50.00m);

Console.WriteLine();

IPaymentGatewayFactory squareFactory = new DigiPayPaymentGatewayFactory();
PaymentService squareService = new PaymentService(squareFactory);
squareService.MakePayment(200.00m);
squareService.RefundPayment(100.00m);