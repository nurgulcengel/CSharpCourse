using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekilOdevi
{
    class Kare : Sekil
    {
        int _kenar;
        public Kare(int kenar)
        {
            this._kenar = kenar;
        }

        public override int AlanHesapla()
        {
            return _kenar * _kenar;
        }

    }
}
