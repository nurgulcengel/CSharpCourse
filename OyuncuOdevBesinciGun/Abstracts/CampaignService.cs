using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyuncuOdevBesinciGun
{
    public abstract class CampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " " + "Eklenmiştir..");
        }


        public void Define(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.Name + " " + gamer.Surname + " " + " oyuncusuna" + " " + campaign.Name + " " + "tanımlanmıştır. ");
        }

        public void Remove(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.Name + " " + gamer.Surname + " " + " oyuncusuna tanımlanan" + " " + campaign.Name + " " + "silinmiştir. ");
        }


    }
}
