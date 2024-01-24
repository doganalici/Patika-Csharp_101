using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Abstract_Class.Sabitler;

namespace Abstract_Class
{
    public interface IOtomobil
    {
        int TekerlekSayisi();
        Marka AracMarka();
        Renk AracRenk();
    }
}
