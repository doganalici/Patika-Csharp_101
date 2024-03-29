﻿
//Değişken Nedir?
//Değişkenler bizim uygulama geliştirirken kullandığımız veri tutucularımızdır. Kullandığımız verinin tipine ve büyüklüğüne bağlı olarak doğru veri tipini seçiyor olmak önemli. Örneğin sadece tek bir karakter tutmaya ihtiyacımız varsa o veri için Char veri tipinizi tanımlamak yeterli olacaktır. String tipinde bir değişken kullanmak gereksizdir. Uygulamanın performansı açısından doğru veri tiplerine karar verebilmek önemlidir.

//Değişken tanımlama yapısı : (Değişken Türü) (Değişken Adı) = (Değeri)

//Değişken tanımlarken dikkat edilmesi gereken bazı hususlar şu şekilde:

//Değişkenler case sensitive yani büyük küçük harf duyarlıdır.
//Değişken isimleri rakamlarla başlayamaz.
//Değişken isimleri boşluk içeremez. Yalnızca "_" ifadesi kullanılabilir.
//Değişken isimlerinin arasında matematiksel ifadeler yani işlem operatörleri kullanılamaz.
//Class namespace gibi özel isimler kullanılamaz.
//Değişkenlerin her zaman bir değeri olmak zorundadır. Yoksa null tanımlanmalıdır.Ataması yapılmayan değişkenler kullanıldığında derleyici hata verir.


Console.WriteLine("");

byte b = 5;     //1 byte
sbyte c = 5;    //1 byte

short s = 5;    //2 byte
ushort us = 5;  //2 byte

Int16 i16 = 2;  //2 byte
int i = 2;      //4 byte
Int32 i32 = 2;  //4 byte
Int64 i64 = 2;  //8 byte

uint ui = 2;    //4 byte
long l = 4;     //8 byte
ulong ul = 4;   //8 byte


//Reeal Sayılar
float f = 5;    //4 byte
double d = 5;   //8 byte
decimal de = 5; //16 byte

char ch = '2';  //3 byte
string str = "Doğan";  //Sınırsız

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now;

object o1 = "x";
object o2 = 'y';
object o3 = 4;
object o4 = 4.3;

//String İfadeler
string str1 = string.Empty;
str1 = "Doğan Alıcı";
string ad = "Doğan";
string soyad = "Alıcı";
string tamIsim = ad + " " + soyad;


//Integer tanımlama şekilleri
int integer1 = 5;
int integer2 = 3;
int integer3 = integer1+ integer2;


//boolean
bool bool1 = 10 < 2;
bool bool2 = 10 > 2;


//Değişken Dönüşümleri
string str20 = "20";
int int20 = 20;
string yeniDeger = str20 + int20.ToString(); //Çıktı=2020

int int21 = int20 + Convert.ToInt32(str20); //Çıktı=40

int int22 = int20 + int.Parse(str20); //Çıktı=40

//Datetime
string datetime=DateTime.Now.ToString("dd.MM.yyyy");

//Saat
string hour=DateTime.Now.ToString("HH:mm");
