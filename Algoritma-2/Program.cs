//Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
//Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

Console.Write("Kök sayıyı giriniz : ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Hesaplamak istediğiniz sayı adedini giriniz : ");
int adet = Convert.ToInt32(Console.ReadLine());
int[] sayiDizisi = new int[adet];

for (int i = 0; i < adet; i++)
{
    Console.Write("{0}. Sayısı Giriniz: ", i + 1);
    sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("-------------");


Console.Write("Kök sayıya eşit yada tam bölünen sayılar ");

for (int i = 0; i < adet; i++)
{
    if (m % sayiDizisi[i] == 0 || m == sayiDizisi[i])
    {
        Console.Write(sayiDizisi[i] + " ");
    }
}


