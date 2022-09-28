using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyuncuOdevBesinciGun
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamerDal gamerManager = new GamerManager(new GamerValidateCheck());
            CampaignManager campaignManager = new CampaignManager();
            GamesSaleManager gamesSaleManager = new GamesSaleManager();



            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.Name = "Black Kampanya";
            campaign.Period = "3 ay geçerli";
            campaign.SaleCount = 1.2;


            Gamer gamer = new Gamer();
            gamer.Id = 100;
            gamer.Name = "Bilbo";
            gamer.Surname = "Baggins";
            gamer.IdentityNo = "56577461780";
            gamer.Place = "Middle Earth";
            gamer.Age = 25;

            Games games = new Games();
            games.Id = 5000;
            games.Name = "Lords";
            games.Price = 100;

            gamerManager.Save(gamer);
            gamesSaleManager.Sale(games, gamer);
            gamesSaleManager.Define(gamer, campaign);
            gamerManager.Update(gamer);
            campaignManager.Remove(gamer, campaign);


            Console.ReadLine();
        }


    }
}
