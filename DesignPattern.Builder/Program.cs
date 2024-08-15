

ISmartPhoneBuilder AndroidBuilder = new ConcreteAndroidPhoneBuilder();
SmartPhoneDirector director1 = new SmartPhoneDirector(AndroidBuilder);

director1.ConstructSmartphone();
Smartphone androidSmartphone = AndroidBuilder.GetResult();
Console.WriteLine(androidSmartphone);


ISmartPhoneBuilder smartPhoneBuilder = new ConcreteApplePhoneBuilder();
SmartPhoneDirector director = new SmartPhoneDirector(smartPhoneBuilder);

director.ConstructSmartphone();
Smartphone appleSmartphone = smartPhoneBuilder.GetResult();
Console.WriteLine(appleSmartphone);

Console.Read();