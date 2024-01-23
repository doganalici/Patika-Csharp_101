//Enum
//Uygulama geliştirirken sabit değerlerle çalışmak durumunda kalırız. Bu noktalarda okunabilirliği yüksek bir program yazmak istiyorsak enum'lardan faydalanırız.

//"enum" anahtar kelimesi enumeration yani numaralandırma kelimesinden gelir. Sayısal verilerı string ifadelerle saklamanızı sağlar. Okunabilirliğe katkısı da tam olarak burdan gelir diyebiliriz.

//    enum Gunler
//{
//    Pazartesi,
//    Sali,
//    Carsamba,
//    Persembe,
//    Cuma,
//    Cumartesi,
//    Pazar
//};

//Yukarıda Gunler enum'ını görüyorsunuz. Enum lar default olarak 1'den başlar.

//Gunler.Pazartesi ifadesi ile Pazartesi'nin string ifadesine erişebiliriz. Eğer Pazartesinin 1. gün oldugu bilgisine ihtiyacımız varsa o da şu şekildedir: (int)Gunler.Pazartesi**


Console.WriteLine(Gunler.Pazar);
Console.WriteLine((int)Gunler.Cumartesi);
Console.WriteLine("---------------");

int sicaklık = 32;
if (sicaklık<=(int)HavaDurumu.Normal)
{
    Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
}
else if (sicaklık>=(int)HavaDurumu.Sicak)
{
    Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün.");
}
else if(sicaklık>=(int)HavaDurumu.Normal && sicaklık>(int)HavaDurumu.CokSicak)
{
    Console.WriteLine("Hadi dışarıya çıkalım");
}

enum Gunler
{
    Pazartesi=1,
    Sali,
    Carsamba,
    Persembe,
    Cuma,
    Cumartesi,
    Pazar
};

enum HavaDurumu
{
    Soguk=5,
    Normal=20,
    Sicak=25,
    CokSicak=30
};