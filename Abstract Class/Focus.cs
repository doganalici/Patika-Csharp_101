using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Focus : IOtomobil
    {
        public Sabitler.Marka AracMarka()
        {
            return Sabitler.Marka.Ford;
        }

        public Sabitler.Renk AracRenk()
        {
            return Sabitler.Renk.Beyaz;
        }

        public int TekerlekSayisi()
        {
            return 4;
        }
    }
}
