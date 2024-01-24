//Abstract Class

//Abstract class'ları sadece kalıtım için kullanılan sınıflar gibi düşünebilirsiniz. Bazı özellikleri ile sınıflara benzerlerken bazı özellikleriyle arayüzlere benzerler. Abstract sınıfları arayüz ve virtual metotların birleşimi gibi davranış gösterirler.

//Kısaca abstract sınıfların özelliklerine bakacak olursak:

//Normal sınıflar gibi new() anahtar kelimesi ile türetilemezler.
//Interface ler gibi metot bildirimi yapabilirsiniz.
//Sanal metotları override eder gibi abstract metotlar override edilebilir.
//Abstract metotların gövdesi yazılamaz.
//Bir abstract class bir abstract metot içeriyorsa, abstract sınıftan türeyen tüm sınıflar bu metodu override etmek zorundadır.
//Bir sınıf sadece tek abstract sınıftan kalıtım alabilir.
//Abstract sınıf başka bir abstract sınıftan kalıtım alabilir.Dolaylı olacak türeyen sınıfta birden fazla abstract dan kalıtım almış olur. Ve bağlantılı olduğu tüm abstract sınıfların bildirimi yapılmış olan abstract metotlarını override etmek zorundadır.

//ÖNEMLI: Abstract sınıf içerisinde metot bildirimi yapabilmek için metodun erişim belirtecinden sonra "abstract" anahtar kelimesi mutlaka yazılmalıdır.

//ÖNEMLI: Abstract metotdan türetilmiş sınıf içerisinde abstract metodun kullanılabilmesi için de override anahtar kelimesinin kullanılması gerekir.

using Abstract_Class;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("****************************");
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

Console.WriteLine("\n");

Console.WriteLine("****************************");
NewFocus focus1 = new NewFocus();
Console.WriteLine($"Araç Markası       : {focus1.AracMarka().ToString()}");
Console.WriteLine($"Araç Rengi         : {focus1.AracRenk().ToString()}");
Console.WriteLine($"Araç Teker Sayısı  : {focus1.TekerlekSayisi().ToString()}");
Console.WriteLine("****************************");

NewCivic civic1 = new NewCivic();
Console.WriteLine($"Araç Markası       : {civic1.AracMarka().ToString()}");
Console.WriteLine($"Araç Rengi         : {civic1.AracRenk().ToString()}");
Console.WriteLine($"Araç Teker Sayısı  : {civic1.TekerlekSayisi().ToString()}");
Console.WriteLine("****************************");

NewCorolla corolla1 = new NewCorolla();
Console.WriteLine($"Araç Markası       : {corolla1.AracMarka().ToString()}");
Console.WriteLine($"Araç Rengi         : {corolla1.AracRenk().ToString()}");
Console.WriteLine($"Araç Teker Sayısı  : {corolla1.TekerlekSayisi().ToString()}");
Console.WriteLine("****************************");


