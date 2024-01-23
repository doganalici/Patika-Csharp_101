//Polymorphism(Çok Biçimcilik)

//Çok biçimcilik ile birlikte hayatımıza sanal yani virtual metotlar giriyor. Virtual metotlar ile nesne yönelimli programlama ilkesi olan polymorphism'i uygularız. Sanal metotlar kalıtım alınan yani miras veren sınıf içerisinde yazılan ve daha sonra alt sınıflarda yeniden yazılabilen metotlardır. Bunu da virtual ve override anahtar kelimeleri sağlar.

//Virtual metot tanımı :

//public virtual void UyaranlaraTepki()
//{
//    Console.WriteLine("Canlılar uyaranlara tepki verir.");
//}


//Alt sınıf içerisinde override metot kullanımı:

//public override void UyaranlaraTepki()
//{
//    base.UyaranlaraTepki(); // üst sınıftaki komutları çalıştırır.
//    Console.WriteLine("Bitkiler güneşe tepki verir.");
//}




using Polymorphism;

TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
tohumluBitkiler.Beslenme();
tohumluBitkiler.Solunum();
tohumluBitkiler.Bosaltim();
tohumluBitkiler.FotosentezYapmak();
tohumluBitkiler.TohumlaCogalma();
Console.WriteLine();
Console.WriteLine("************************************");
Console.WriteLine();
Kuslar kuslar = new Kuslar();
kuslar.Solunum();
kuslar.Beslenme();
kuslar.Bosaltim();
kuslar.Ucmak();
kuslar.UyaranlaraTepki();
