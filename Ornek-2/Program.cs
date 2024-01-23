//Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

//Negatif ve numeric olmayan girişleri engelleyin. ++
//Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
//Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.


using System.Collections;

int sayi;
ArrayList asalOlan = new ArrayList();
ArrayList asalOlmayan = new ArrayList();

for (int i = 0; i < 20; i++)
{

    Console.Write($"{i + 1}. sayı : ");
    sayi=Convert.ToInt32( Console.ReadLine() );
    if ( sayi < 0)
    {
        Console.WriteLine("Hata");
        break;
    }
    else if (AsalMi(sayi))
    {
        asalOlan.Add(sayi);
    }
    else
    {
        asalOlmayan.Add(sayi);
    }
}

asalOlan.Sort();
asalOlan.Reverse();
asalOlmayan.Sort();
asalOlmayan.Reverse();


Console.WriteLine("***************************************");
Console.WriteLine("Asal sayılar : ");
Yazdir(asalOlan);


Console.WriteLine("***************************************");
Console.WriteLine("Asal olmayan sayılar : ");
Yazdir(asalOlmayan);


Console.WriteLine("***************************************");
Console.WriteLine($"Asal olan sayıların toplamı : {Toplam(asalOlan)}");
Console.WriteLine($"Asal olmayan sayıların toplamı : {Toplam(asalOlmayan)}");


Console.WriteLine("***************************************");
Console.WriteLine($"Asal olan sayıların ortalaması : {Ortalama(asalOlan)}");
Console.WriteLine($"Asal olmayan sayıların ortalaması : {Ortalama(asalOlmayan)}");



static bool AsalMi(int sayi)
{
    if (sayi < 2)
        return false;

    for (int i = 2; i <= Math.Sqrt(sayi); i++)
    {
        if (sayi % i == 0)
            return false;
    }

    return true;
}

static void Yazdir(ArrayList liste)
{
    foreach (var i in liste)
    {
        Console.WriteLine($"{i}");
    }
    Console.WriteLine($"Toplam eleman sayısı : {liste.Count}");
    Console.WriteLine();
}

static int Toplam(ArrayList liste)
{
    int toplam = 0;
    foreach (var i in liste) 
    {
        toplam += (int)i;
    }
    return toplam;
}

static double Ortalama(ArrayList liste)
{
    if(liste.Count == 0) return 0;
    return (double)Toplam(liste)/liste.Count;
}