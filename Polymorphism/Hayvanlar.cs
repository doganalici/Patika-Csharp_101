using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Hayvanlar : Canlilar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir.");
        }
    }
    public class Surungenler : Hayvanlar
    {
        public void SurunerekHareketEdenler()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }

    public class Kuslar : Hayvanlar
    {
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar.");
        }
    }
}
