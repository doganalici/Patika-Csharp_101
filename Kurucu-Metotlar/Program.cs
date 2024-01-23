//Constructor Kavramı

//Bir sınıftan bir nesne oluşturulduğunda biz tanımlamasak bile arka planda çalışan varsayılan yapıcı metotlara kurucu yada constructor denir. Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri kurucu metotlar içerisinde yaparız.

//Kurucu metot tanımlarken dikkat edilmesi gereken noktalar ise şu şekildedir:

//Yapıcı metotların isimleri sınıf isimleri ile aynı olmak zorundadır.
//Public olarak bildirilmeleri gerekir.
//Geri dönüş değerleri yoktur.

//Kurucu metotların imzasını değiştirerek overload edebiliriz yani aşırı yükleyebiliriz.

//Varsayılan Kurucu Metot

//Her sınıfın biz tanımlamasakta bir tane kurucu metotu vardır. Buna varsayılan kurucu metot (default constructor) denir.


//Default constructor'ın görevi sınıfın içerindeki özelliklere ilk değer ataması yapılmadığında onların default değerlerini set etmektir. Şöyle düşünebilirsiniz; sınıf içerisinde string veri tipinde bir özellik varsa ve siz ilk değer atamasını yapmazsanız varsayılan kurucu onun atamasını arka planda null olarak yapar. Aynı integer tipinde bir özelliğin ilk değer atamasını 0 olarak yapar.


Calisan calisan1 = new Calisan();
calisan1.Ad = "Doğan";
calisan1.Soyad = "Alıcı";
calisan1.No = 23415684;
calisan1.Departman = "İnsan Kaynakları";

Console.WriteLine("ÇALIŞAN 1\n");
calisan1.CalisanBilgileriYazdir();

Console.WriteLine("********************************************");

Calisan calisan2 = new Calisan("doğan", "alıcı", 49741576, "Satın Alma");
Console.WriteLine("ÇALIŞAN 2\n");
calisan2.CalisanBilgileriYazdir();
Console.WriteLine("********************************************");

Calisan calisan3 = new Calisan("DOĞAN", "ALİCİ");
Console.WriteLine("ÇALIŞAN 3\n");
calisan3.CalisanBilgileriYazdir();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;

    }
    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }
    public Calisan()
    {

    }

    public void CalisanBilgileriYazdir()
    {
        Console.WriteLine($"Çalışanın Adı : {Ad}");
        Console.WriteLine($"Çalışanın Soyadı : {Soyad}");
        Console.WriteLine($"Çalışanın Numarası : {No}");
        Console.WriteLine($"Çalışanın Departmanı : {Departman}");
    }
}