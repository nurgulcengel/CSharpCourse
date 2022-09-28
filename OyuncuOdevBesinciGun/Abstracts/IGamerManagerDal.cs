using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyuncuOdevBesinciGun
{
    internal interface IGamerDal
    {

        void Save(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);

    }

}


