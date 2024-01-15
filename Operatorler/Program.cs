
//Uygulama içerisinden bir atama işlemi ya da durum karşılaştırması yapmak istediğimizde operatörleri kullanırız. Bazen koşullara bağlı olarak çalıştırılacak kod bloğunun değişmesi gerekir. Karar yapıları ve operatörler birlikte kullanılarak bu sağlanabilir.

//İşlevlerine göre operatörler aşağıdaki gibi kategorilendirilir.

//Atama ve İşlemli Atama Operatörleri (=, +=, -=, *=, /=)
//Mantıksal Operatörler (||, &&, !)
//İlişkisel Operatörler (==,!=, <, >, >=,<=)
//Aritmetik (+, -, *, /, %, ++, --)


//Atama ve İşlemli Atama
int x = 3;
int y = 3;
y = y + 2;
y += 2;

y /= 1;
x *= 2;


//Mantıksal Operatörler
bool isSuccess = true;
bool isCompleted = false;

if (isSuccess && isCompleted)
{
    Console.WriteLine("Perfect!");
}

if (isSuccess || isCompleted)
{
    Console.WriteLine("Great!");
}

if (isSuccess && !isCompleted)
{
    Console.WriteLine("Fine");
}


//İlişkisel Operatörler
int a = 3;
int b = 4;
bool sonuc = a < b;

sonuc = a > b;
sonuc = a >= b;
sonuc = a <= b;
sonuc = a == b;
sonuc = a != b;


//Aritmetik Operatörler
int sayi1 = 10;
int sayi2 = 5;
int sonuc1=sayi1/sayi2;

sonuc1 = sayi1 * sayi2;
sonuc1 = sayi1 + sayi2;
sonuc1 = sayi1 - sayi2;
sonuc1 = sayi1++;

int sonuc2 = 20 % 3;