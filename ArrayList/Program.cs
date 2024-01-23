//ArrayList Nedir ?


//Standart dizilerde aynı tipte verileri verileri bir arada tutabileceğimizi ve dizinin boyutunun belirtilmesi gerektiğinden bahsetmiştik. Arraylist tam olarak bu noktada farklılaşıyor. Farklı veri tiplerini array list içerisinde saklayabilirsiniz. Ve eleman ekleyerek ve cıkararak boyutunu dinamik olarak değiştirebilirsiniz.


//Varsayılan boyutu başlangıç olarak 4'tür. Aşıldığından otomatik olarak 2 katına çıkarılır. Yani bir array liste 5. elemanı eklemeye calıştıgınızda atka planda boyutunun 8'e çıkarır.

//Örnek:

//ArrayList dizi = new ArrayList();
//dizi.Add("Kedi");
//dizi.Add(99);
//dizi.Add(true);


//Yukarıdaki örnekte tanımladıgımız ArrayList içerisine string, integer ve bool veri tipindeki verileri aynı koyduk.


//Değişken veri tipi kullanımı kulağa ilk etapta çok konforlu gelse de risk barındır. Listeden okudugunuz verinin tipinin ne olduğunu bilmemek güvenli bir yaklaşım değildir. Tip dönüşümleri sırasında hata ihtimalini arttırır.

using System.Collections;

ArrayList liste = new ArrayList();
liste.Add("Doğan");
liste.Add(2);
liste.Add(true);
liste.Add('A');


//içerisindeki verilere erişim
Console.WriteLine(liste[1]);
Console.WriteLine("-----------------------------");

foreach (var i in liste)
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------");


//AddRange
string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
List<int> sayilar = new List<int>() { 1,8,3,7,9,92,5};
liste.AddRange(renkler);
liste.AddRange(sayilar);

foreach (var i in liste)
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------");


//Sort
//liste.Sort();
//Console.WriteLine("-----------------------------");


//Binary Search
//Console.WriteLine(liste.BinarySearch(9));
//Console.WriteLine("-----------------------------");


//Reverse
liste.Reverse();
foreach (var i in liste)
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------");


//Clear
liste.Clear();
foreach (var i in liste)
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------");