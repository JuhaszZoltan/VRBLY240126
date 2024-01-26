using RealEstateCLI;
var ads = Ad.LoadFromCSV("realestates.csv");
var f1 = ads.Where(a => a.Floors == 0).Average(a => a.Area);
Console.WriteLine($"1.: foldszinti ingatlanok atlagos alapterulete: {f1:0.00} m^2");
var mo = (47.4164220114023, 19.066342425796986);
var f2 = ads.Where(a => a.FreeOfCharge).MinBy(a => a.DistanceTo(mo));
Console.WriteLine($"2.: mesevar ovodahoz legvonalban legkozelebbi ingatlan adatai:\n" +
    $"{f2}");
