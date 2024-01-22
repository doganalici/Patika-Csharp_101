//Generic Koleksiyonlar

//Generic list System.Colections.Generic isim uzayı altında bulunan bit list sınıfı koleksiyonudur. Generic List bir list sınıfı tanımlarken T olarak tip değişkenini alır. Generic olmasını sağlayan da burdaki T veri tipidir. T listenin hangi türden veri tutacağını belirler. Bu tanımlama sonunda farklı türden bir veri tipini generic list ile saklayamazsınız.


//Örnek söz dizimi şu şekildedir:

//List<string> renkler = new List<string>();
//renkler.Add("Mavi");
//renkler.Add("Kırmızı");


List<int> sayiListesi = new List<int>();

sayiListesi.Add(23);
sayiListesi.Add(10);
sayiListesi.Add(4);
sayiListesi.Add(5);
sayiListesi.Add(92);
sayiListesi.Add(34);


List<string> renkListesi = new List<string>();

renkListesi.Add("Kırmızı");
renkListesi.Add("Mavi");
renkListesi.Add("Turuncu");
renkListesi.Add("Sarı");
renkListesi.Add("Yeşil");


//Count
Console.WriteLine($"Renk sayısı : {renkListesi.Count}");
Console.WriteLine($"Sayı adedi : {sayiListesi.Count}");
Console.WriteLine("-----------------------------");


//Foreach ve List.ForEach ile elemanlara erişim
Console.WriteLine("Sayılar\n");
foreach (var sayi in sayiListesi)
{

    Console.WriteLine(sayi);
}
Console.WriteLine("-----------------------------");

Console.WriteLine("Renkler\n");
foreach (var renk in renkListesi)
{

    Console.WriteLine(renk);
}
Console.WriteLine("-----------------------------");

Console.WriteLine("Sayılar\n");
sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
Console.WriteLine("-----------------------------");

Console.WriteLine("Renkler\n");
renkListesi.ForEach(renk => Console.WriteLine(renk));

Console.WriteLine("-----------------------------");


//Listeden eleman çıkarma
sayiListesi.Remove(4);
renkListesi.Remove("Yeşil");

Console.WriteLine("Sayılar\n");
sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
Console.WriteLine("-----------------------------");

Console.WriteLine("Renkler\n");
renkListesi.ForEach(renk => Console.WriteLine(renk));

Console.WriteLine("-----------------------------");

sayiListesi.RemoveAt(0);
renkListesi.RemoveAt(1);

Console.WriteLine("Sayılar\n");
sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
Console.WriteLine("-----------------------------");

Console.WriteLine("Renkler\n");
renkListesi.ForEach(renk => Console.WriteLine(renk));

Console.WriteLine("-----------------------------");


//Liste içerisinde arama
if (sayiListesi.Contains(10))
{
    Console.WriteLine("10 liste içerisinde bulundu");
}
Console.WriteLine("-----------------------------");


//Eleman ile indexe erişme
Console.WriteLine(renkListesi.BinarySearch("Sarı"));
Console.WriteLine("-----------------------------");


//Diziyi list'e çevirme
string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
List<string> hayvanListesi = new List<string>(hayvanlar);


//Listeyi nasıl temizlerim
hayvanListesi.Clear();


//List içerisinde nesne tutmak
List<Kullanicilar> kullanıcıListesi = new List<Kullanicilar>();
Kullanicilar Kullanici1 = new Kullanicilar();
Kullanici1.Isim = "Doğan";
Kullanici1.Soyisim = "Alıcı";
Kullanici1.Yas = 26;

Kullanicilar Kullanici2 = new Kullanicilar();
Kullanici2.Isim = "DOGAN";
Kullanici2.Soyisim = "ALICI";
Kullanici2.Yas = 22;

kullanıcıListesi.Add(Kullanici1);
kullanıcıListesi.Add(Kullanici2);


List<Kullanicilar> yeniListe = new List<Kullanicilar>();
yeniListe.Add(new Kullanicilar()
{
    Isim = "DoĞaN",
    Soyisim = "AlIcI",
    Yas = 29
});

foreach (var kullanici in kullanıcıListesi)
{
    Console.WriteLine($"Kullanıcı Adı : {kullanici.Isim}");
    Console.WriteLine($"Kullanıcı Soyadım : {kullanici.Soyisim}");
    Console.WriteLine($"Kullanıcı Yaş : {kullanici.Yas}");
    Console.WriteLine();
}
Console.WriteLine("-----------------------------");
public class Kullanicilar
{
    public string Isim { get; set; }
    public string Soyisim { get; set; }
    public int Yas { get; set; }
}
