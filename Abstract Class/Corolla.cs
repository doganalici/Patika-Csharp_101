using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Corolla : IOtomobil
    {
        public Sabitler.Marka AracMarka()
        {
            return Sabitler.Marka.Toyota;
        }

        public Sabitler.Renk AracRenk()
        {
            return Sabitler.Renk.Gri;
        }

        public int TekerlekSayisi()
        {
            return 4;
        }
    }
}
