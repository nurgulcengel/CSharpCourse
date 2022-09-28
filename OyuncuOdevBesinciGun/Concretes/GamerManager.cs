using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyuncuOdevBesinciGun
{
    class GamerManager : IGamerDal
    {
        IGamerValidateCheckDal gamerValidateCheckDal;

        public GamerManager(IGamerValidateCheckDal item)
        {
            gamerValidateCheckDal = item;
        }


        public void Save(Gamer gamer)
        {
            if (gamerValidateCheckDal.Validate(gamer))
            {
                Console.WriteLine(gamer.Name + " " + gamer.Surname + " " + "Adlı kişi kaydedilmiştir..");
            }
            else
            {
                Console.WriteLine("Bu kişi bulunamadı..");
            }

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " " + gamer.Surname + " " + "Adlı kişinin bilgileri güncellenmiştir..");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " " + gamer.Surname + " " + "Adlı kişi silinmiştir..");
        }


    }
}
