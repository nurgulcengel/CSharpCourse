using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyuncuOdevBesinciGun
{
    class GamerValidateCheck : IGamerValidateCheckDal
    {
        public bool Validate(Gamer gamer)
        {
            
            if (gamer.IdentityNo.Length==11 && gamer.Age>18 && !string.IsNullOrEmpty(gamer.Name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
