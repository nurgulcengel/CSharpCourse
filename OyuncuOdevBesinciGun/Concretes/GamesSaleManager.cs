using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyuncuOdevBesinciGun
{
    class GamesSaleManager:CampaignService
    {

        public void Sale(Games games, Gamer gamer)
        {
            Console.WriteLine(games.Name+" "+ "Adlı oyun" + " "+gamer.Name+" kişisine satılmıştır.");
        }



    }
}
