//Struct(Yapı) Nedir?

//Struct'lar yani yapılar sınıflara çok benzerler. Struct ile yapıp sınıf ile yapamayacağız bir işlem yoktur diyebiliriz. Peki o halde struct yani yapılara neden ihtiyaç duyulur?

//Class kullanmanızı gerektirecek kadar komplex olmayan yapılarınız varsa ve verileri kapsüllemek işinizi görecekse yapıları tercih edebilirsiniz.

//Yapıların özellikleri:

//Class lar referans tipli özellikler gösterir, Yapılar ise değer tipli özellikler gösterirler. En temel fark budur.
//Diğer struct ya da sınıflardan kalıtım almazlar.
//Interface'lerden kalıtım alabilirler.
//new anahtar sözcüğü ile nesneleri yaratılabilir.
//Sınıflar gibi metot, property ve field'lardan oluşurlar.
//Sınıf içerisinde struct, struct içerisinde de sınıf oluşturulabilir.
//Static üye barındırabilirler.

//Yapıların söz dizimi:

//struct Ogrenci
//{
//    public string Isim;
//    public string Soyisim { get; set; }
//    public static int OgrenciSayısı = 0;
//}

Dikdortgen dikdortgen = new Dikdortgen();
dikdortgen.KisaKenar = 5;
dikdortgen.UzunKenar = 6;

Console.Write($"Class alan hesabı : {dikdortgen.AlanHesapla()}");
Console.WriteLine();

Dikdortgen_Struct dikdortgen_Struct=new Dikdortgen_Struct();
dikdortgen_Struct.KisaKenar = 5;
dikdortgen_Struct.UzunKenar = 6;
Console.Write($"Struct alan hesabı : {dikdortgen_Struct.AlanHesapla()}");
Console.WriteLine();


class Dikdortgen
{
    public int KisaKenar { get; set; }
    public int UzunKenar { get; set; }

    public long AlanHesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }
}

    struct Dikdortgen_Struct
    {
        public int KisaKenar { get; set; }
        public int UzunKenar { get; set; }
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }

