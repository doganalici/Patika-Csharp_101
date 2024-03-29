﻿//Static Sınıf ve Üyeler

//Static Üyeler

//Bir sınıfın static olamayan üyelerine nesneler aracılığıyla erişirken static olan metotlara ve özelliklere ise nesne oluşturmadan o sınıfın ismi aracılığıyla erişiriz.

//    class Ogrenci
//{
//    public static int OgrenciSayisi = 0;
//    public string Isim;
//    public string Soyisim;
//    public Ogrenci()
//    {
//        OgrenciSayisi++;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        //Static sınıf üyesine erişim
//        Console.WriteLine("Öğrenci sayısı: {0}", Ogrenci.OgrenciSayisi);

//        //Static olmayan sinif üyesine erişim
//        Ogrenci ogrenci1 = new Ogrenci();
//        ogrenci1.Isim = "Deniz";
//        ogrenci1.Soyisim = "Arda";

//        Ogrenci ogrenci2 = new Ogrenci();
//        ogrenci2.Isim = "Ayşe";
//        ogrenci2.Soyisim = "Yılmaz";

//        Console.WriteLine("Öğrenci Sayısı: {0}", Ogrenci.OgrenciSayisi);
//    }
//}

//Yukarıda hem static hemde static olmayan sınıf üyesine sahip bir sınıf tanımı ve program içerisinden kullanımı görüyorsunuz. Static olmayan üyeler nesne bazında yaratılırken static sınıf üyeleri uygulama çalıştığı sürece kendilerine atanan veriyi tutarlar. Yani yukarıdaki örnek için konuşursak, "Isim" ve "Soyisim" her nesne yaratıldığında başlangıç değeri olarak null alır, ataması yapıldığındaysa nesne bazında değerini tutar. Ama "Ogrenci Sayısı" field'ı program boyunca nesne yaratıldıkça öğrenci sayısının değerini 1 arttırarak bu veriyi korur.

//Yukarıdaki örnekte de görebileceğiniz gibi bir özelliği static yapmak için geri dönüş tipi ya da veri tipinden önce erişim belirleyiciden sonra "static" anahtar kelimesini koymanız yeterlidir.

//Normal metotlar gibi kurucu metotları da static olarak tanımlayabiliriz.Sınıfın static üyelerinin başlangıç değerlerini static kurucular aracılığıyla yapabiliriz. Parametre almazlar ve erişim belirleyicileri yoktur.


//Static Sınıflar

//Metotlar ve özellikler gibi sınıflar da static anahtar kelimesi ile oluşturulabilirler. Yukarıdaki örnekte de görebileceğiniz üzere normal sınıflar içerisinde static metotlar ve üyeler kullanabiliriz. Peki o halde neden sınıfları static yapma ihtiyacımız olsun? Buna okunabilirliği arttırmak için diyebiliriz.

//Bir sınıfın tüm üyeleri static ise sınıfı da static yapmak kullanımı kolaylaştıran bir yaklaşım olur.


Console.Write($"Çalışan Sayısı : {Calisan.CalisanSayisi}");
Console.WriteLine();
Calisan calisan1 = new Calisan("Doğan", "Alıcı", "İnsan Kaynakları");
Console.Write($"Çalışan Sayısı : {Calisan.CalisanSayisi}");
Console.WriteLine();
Calisan calisan2 = new Calisan("Doğan", "Alıcı", "İnsan Kaynakları");
Calisan calisan3 = new Calisan("Doğan", "Alıcı", "İnsan Kaynakları");
Console.Write($"Çalışan Sayısı : {Calisan.CalisanSayisi}");

class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get; set; }


    private string Isim;
    private string Soyisim;
    private string Departman;

    static Calisan()
    {
        calisanSayisi = 0;
    }

    public Calisan(string isim, string soyisim, string departman)
    {
        this.Isim = isim;
        this.Soyisim = soyisim;
        this.Departman = departman;
        calisanSayisi++;
    }
}