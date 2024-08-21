var builder = new SmartphoneBuilder();
var director = new SmartphoneDirector(builder);

var applePhone = director.ConstructApplePhone();
const string line = "--------------------------------------------------------------------------------------------------------------------";
Console.WriteLine(line);
Console.WriteLine(applePhone);

builder.Reset();


var androidPhone = director.ConstructAndroidPhone();
Console.WriteLine(line);
Console.WriteLine(androidPhone);

builder.Reset();

var customPhone = builder.BuildBattery("6000mAh")
                                    .BuildBrand("Samsung")
                                    .BuildCamera(4)
                                    .BuildScreen(true)  
                                    .BuildAndroidOS(true)
                                    .BuildWaterProof(true)
                                    .GetSmartphone();

Console.WriteLine(line);
Console.WriteLine(customPhone);
Console.WriteLine(line);

Console.Read();