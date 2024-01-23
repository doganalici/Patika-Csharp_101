//Dictionary Nedir ?

//Dictionary koleksiyonunda key-value yani anahtar-deger denen 2 kavram ile karşılaşıyoruz. Dizilere eklediğimiz elemanları value, index lerini ise key olarak düşünebilirsiniz.

//Dictionary lerin elemanlarının anahtarları birbirinden farklı olmalıdır. Aynı anahtar kullanılarak 2 değer saklanamaz.

//Örnek söz dizimi şu şekildedir:

//Dictionary<Key_Veri_Tipi, Value_Veri_Tipi> dictionary_adi = new Dictionary<Key_Veri_Tipi, Value_Veri_Tipi>();


//Örnek:

//Dictionary<int, string> renkler = new Dictionary<int, string>();
//renkler.Add(3, "Kırmızı");
//renkler.Add(5, "Sarı");

//Yukarıdaki örnekte anatarı integer olan, değeri string olan renkler adında bir dictionary tanımladık. 3-"Kırmızı", 5-"Sarı" ikililerini dictionary'e ekledik.


using System.Collections.Generic;

Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
kullanicilar.Add(10, "Doğan Alıcı");
kullanicilar.Add(12, "DOĞAN ALICI");
kullanicilar.Add(18, "doğan alıcı");
kullanicilar.Add(20, "DoGaN Alİcİ");


//Dizinin elemanlarına erişim
Console.WriteLine(kullanicilar[12]);
Console.WriteLine("-----------------------------");

foreach (var i in kullanicilar)
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------");


//Count
Console.WriteLine(kullanicilar.Count);
Console.WriteLine("-----------------------------");


//Contains
Console.WriteLine(kullanicilar.ContainsKey(12));
Console.WriteLine(kullanicilar.ContainsValue("doğan alıcı"));
Console.WriteLine("-----------------------------");


//Remove
Console.WriteLine(kullanicilar.Remove(12));
foreach (var i in kullanicilar)
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------");


//Keys
foreach (var i in kullanicilar.Keys)
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------");


//Values
foreach (var i in kullanicilar.Values)
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------");