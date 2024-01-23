﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Canlilar
    {
        public void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir.");
        }

        public void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }

        public void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım yapar.");
        }


        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }
}
