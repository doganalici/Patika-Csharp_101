using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Abstract_Class.Sabitler;

namespace Abstract_Class
{
    public abstract class Otomobil
    {
        public int TekerlekSayisi()
        {
            return 4;
        }

        public virtual Renk AracRenk()
        {
            return Renk.Beyaz;
        }

        public abstract Marka AracMarka();
    }
}
