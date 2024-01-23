//Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
//her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını
//console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

int sayi;
int[] sayilar=new int[20];

for (int i = 0; i < 20; i++)
{
    Console.Write($"{i+1}. sayı : ");
    sayi=Convert.ToInt32( Console.ReadLine());
}

int[] enKucukler=new int[3];
int[] enBuyukler=new int[3];