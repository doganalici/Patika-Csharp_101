using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Interface_Ornek.Sabitler;

namespace Interface_Ornek
{
    public interface IOtomobil
    {
        int TekerlekSayisi();
        Marka AracMarka();
        Renk AracRenk();
    }
}
