using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class NewCivic : Otomobil
    {
        public override Sabitler.Marka AracMarka()
        {
            return Sabitler.Marka.Honda;
        }

        public override Sabitler.Renk AracRenk()
        {
            return Sabitler.Renk.Gri;
        }
    }
}
