using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odevlerim
{
    class BelgeManager 
    {
      
        public void BelgeOlusturma()
        {
            Console.WriteLine("Belge oluşturuldu..");
        }

        public void BelgeGuncelleme()
        {
            Console.WriteLine("Belge güncellendi..");
        } 

        public void BelgeOnaylama()
        {
            Console.WriteLine("Belge Onaylandı..");
        }

        public void BelgeOnayGeriAlma()
        {
            Console.WriteLine("Belge onayı geri çekildi");
        }

        public void BelgeGonderme()
        {
            Console.WriteLine("Belge gönderildi..");
        }


    }
}
