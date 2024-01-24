using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class NewCorolla : Otomobil
    {
        public override Sabitler.Marka AracMarka()
        {
            return Sabitler.Marka.Toyota;
        }
    }
}
