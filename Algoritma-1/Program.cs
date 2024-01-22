//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
//Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

Console.Write("Hesaplamak istediğiniz sayı adedini giriniz : ");
int adet=Convert.ToInt32(Console.ReadLine());

int[] sayiDizisi= new int[adet];
Console.WriteLine();
for (int i = 0; i < adet; i++)
{
    Console.Write("{0}. Sayısı Giriniz: ", i + 1);
    sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("-------------");

Console.Write("Girmiş Olduğunuz Çift Sayı/Sayılar: ");

for (int i = 0; i < adet; i++)
{
    if (sayiDizisi[i] % 2 == 0)
    {
        Console.Write(sayiDizisi[i] + " ");
    }
}
