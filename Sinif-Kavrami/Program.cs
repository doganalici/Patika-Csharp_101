//Sinif Sözdizimi, Field ve Metot Tanımlama, Erişim Belirleyiciler
//Sınıf Nedir, Neden İhtiyaç Duyarız ?

//Sınıflar Nesne Yönelimli Programlamanın en öneeli öğesidir. C# %100 nesne yönelimli bir dil olduğu için tüm metot ve özellikler sınıflar içerisinde yer alır.

//Metotlardan bahsederken bütün işlemleri tek bir metot içerisinde yazmak yerine, parçalarına yani alt metotlara ayırmak kod tekrarını azaltırken okunabilirliği arttırır demiştik. Üstelik bu şekilde yazdığınız programların daha kolay genişleyebildiğini görürsünüz.

//Aynı şekilde program geliştirirken bütün metotları tek bir sınıf içerisinde yazmak yerine benzer görevleri olan metotları tek bir sınıf içerisinde toplamak en doğru yaklaşımdır.

//Bir sınıfın temelde 2 tipte öğesi vardır; field / özellik ve metotlar. Aşağıda örnek bir sınıf tanımının söz dizimini görebilirsiniz.

//class SinifAdi
//{
//    [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
//    [Erişim Belirleyici]
//    [Geri Dönüş Değerinin Tipi]
//    MetotAdi([Parametreler])
//    {
//        //Metot Gövdesi
//    }
//}
//Erişim Belirleyiciler
//Erişim belirleyiciler önüne geldiği öğenin projenin nerelerinden erişilebileceğini belirler. Öğeleri korur gibi düşünebilirsiniz.

//1. Public : Her yerden erişilebilir.

//2. Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.

//3. Internal : Sadece bulunduğu proje içerisinden erişilebilir

//4. Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.


Calisan calisan1 = new Calisan();
calisan1.Ad = "Doğan";
calisan1.Soyad = "Alıcı";
calisan1.No = 23415684;
calisan1.Departman = "İnsan Kaynakları";

calisan1.CalisanBilgileriYazdir();
Console.WriteLine("********************************************");
Calisan calisan2 = new Calisan();
calisan2.Ad = "doğan";
calisan2.Soyad = "alıcı";
calisan2.No = 49741576;
calisan2.Departman = "Satın Alma";

calisan2.CalisanBilgileriYazdir();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileriYazdir()
    {
        Console.WriteLine($"Çalışanın Adı : {Ad}");
        Console.WriteLine($"Çalışanın Soyadı : {Soyad}");
        Console.WriteLine($"Çalışanın Numarası : {No}");
        Console.WriteLine($"Çalışanın Departmanı : {Departman}");
    }
}