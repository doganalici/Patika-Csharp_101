//Koleksiyon(Collections) Nedir?

//    Klasik programlama dillerinde array yani diziler çok önemli veri tipleridir. Birçok problemimizi diziler yardımıyla çözebiliriz ama bazı handikapları nedeniyle birçok sorun karşısında da yetersiz kalırlar.Bu sorunları şöyle sıralayabiliriz:



//Array'in elemanları aynı veri tipinde olmalıdır.
//Array'in boyutu önceden belirlenmelidir.


//Oysa programlama dillerinde farklı türlerde verileri saklamaya ihtiyaç duyarız. Ve çoğu zaman ne kadar veri saklayacağımız program akışında belli olabilir. Koleksiyonlar tam da bu sorunları çözmek için dizilerin handikaplarından yaratılmıştır.



//Dizilerin aksine koleksiyonların bazı tipleri; üzerinde çalıştıkları makinaın RAM'i yettiği sürece genişleyebilirler ve farklı türlerde veri tiplerini saklayabilirler.

//Koleksiyonların elemanları object tipindedir. Hatırlayacak olursak öğrendiğimiz veri tipleri için object sınıfından türediklerini söylemiştik. Yani bu bir sorun değil, her türlü veriyi koleksiyonlar içerisinde saklayabiliriz.



//Koleksiyonlar System.Collections namespace i yani isim uzayı altında bulunurlar.Yani bir koleksiyon tipini kullanmak istiyorsanız System.Collections'ı using direktifi ile programınıza import ediyor olmanız gerekiyor.



//Peki bu Koleksiyonlar'ın hiç dezavantajı yok mu? Olmaz olur mu tabiki var. Gelin yakından bakalım.

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//Dezavantajları


//.NEt platformda kullanıdığımız veri tipleri 2'ye ayrılır. Değer ve referans veri tipleridir. Değer tipleri belliğin stack bölgesinde tutulurken, Referans tipleri belleğin heap bölgesinde tutulur.



//Değer Tipleri: int, long, float, double, decimal, char, bool, byte, short, struct, enum


//Referans Tipleri: string, object, class, interface, array, delegate, pointer




//Bir değer tipinin referans tipine dönüştürülme boxing, tam tersine unboxing işlemi denir.

//Koleksiyonlar verilerini object tipinde tutuyor demiştik. Object de bir referans tipi.Bu demek oluyor ki değer tipinde bir veriyi koleksiyona eklemek istediğimde bir boxing işlemi yapıyorum.Daha sonra elemanı okumak istediğimde de unboxing işlemi yapıyorum.Boxing ve unboxing işlemleri bilgisayar açısından maliyetli bir işlemdir.Koleksiyon içerisindeki eleman sayısının artışına bağlı olarak bu boxing ve unboxing işlemlerinin sayısı artacaktır. Buna bağlı olarakta uygulamanın performansı olumsuz yönde etkilenecektir.

//-------------------------------------------------------------------------------------------------------------------------------------------------

//Stack:

//Stack candır. Kullanımı kolaydır.
//Bilgisayarda RAM’de tutulur. Tıpkı Heap gibi.
//Oluşturulan değişkinler stack kapsamından çıkınca otomatik olarak yok edilir.
//Ulaşılması heap‘e göre oldukça hızlıdır.
//Stack üzerinde kullanım fazla olduğunda alan yeterli olmayabilir. Mesela 20 boyutlu bir diziye 21 eleman atamak gibi…
//Oluşturulan değişkenler pointer olmadan kullanılabilir.
//Derleme zamanında oluşturulur.
//Kullanacağınız yerin boyutunu tam olarak biliyorsanız Stack‘i kullanmak sizin için uygun olacaktır.

//Heap:

//Heap biraz nazlıdır. Ama nazını çekerseniz oda sizin yükünüzü çeker.
//Bilgisayarda RAM’de tutulur.Tıpkı Stack gibi.
//Bir blok içerisinde oluşturulan heap değişkenler, bloğun dışına çıktığında otomatik olarak yok edilemez, bunun manuel olarak yapılması gerekir.
//Stack ile karşılaştırıldığında oldukça yavaştır.
//Doğru kullanılmaması durumunda bellek sorunları yaratır.
//Değişkenler pointer ile kullanılır.
//Çalışma zamanında oluşturulur.
//İhtiyacınız olan boyutu tam olarak bilmiyorsanız Heap kullanımı sizin için biçilmiş kaftandır.