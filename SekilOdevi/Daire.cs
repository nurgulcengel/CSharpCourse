using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekilOdevi
{
    class Daire : Sekil
    {
        int _cap;
        const int pi = 3;
        public Daire(int cap)
        {
            this._cap = cap;
        }

        public override int AlanHesapla()
        {
            return pi * (_cap * _cap);
        }
      
    }
}
