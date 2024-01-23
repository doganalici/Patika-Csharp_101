using Interface_Ornek;

Focus focus = new Focus();
Console.WriteLine($"Araç Markası       : {focus.AracMarka().ToString()}");
Console.WriteLine($"Araç Rengi         : {focus.AracRenk().ToString()}");
Console.WriteLine($"Araç Teker Sayısı  : {focus.TekerlekSayisi().ToString()}");
Console.WriteLine("****************************");

Civic civic = new Civic();
Console.WriteLine($"Araç Markası       : {civic.AracMarka().ToString()}");
Console.WriteLine($"Araç Rengi         : {civic.AracRenk().ToString()}");
Console.WriteLine($"Araç Teker Sayısı  : {civic.TekerlekSayisi().ToString()}");
Console.WriteLine("****************************");

Corolla corolla = new Corolla();
Console.WriteLine($"Araç Markası       : {corolla.AracMarka().ToString()}");
Console.WriteLine($"Araç Rengi         : {corolla.AracRenk().ToString()}");
Console.WriteLine($"Araç Teker Sayısı  : {corolla.TekerlekSayisi().ToString()}");
Console.WriteLine("****************************");

