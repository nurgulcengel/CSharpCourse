using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurkiOdev
{
    public class Menu
    {

        public void Menux()
        {

            List<string> secenekler = new List<string> { "(a) girişlerimdeki tek sayıları listele", "(b) girişlerimdeki çift sayıları listele",
            "(c) girişlerimdeki metinlerde kullanılan toplam sesli harf sayısı?","(d) girişlerimdeki metinlerde kullanılan toplam sessiz harf sayısı?",
            "(e) girişlerimdeki sayıları listele","(f) girişlerimdeki metinleri listele","(g) tüm girişlerimi listele",
            "(x) ÇIKIŞ"};
            foreach (var i in secenekler)
            {
                Console.WriteLine(i);
            }
            while (true)
            {
                string girilenDeger = Console.ReadLine();

                if (girilenDeger == "x")
                {
                    Console.WriteLine("Veri girişi sonlandı...");
                    break;

                }
                else if (girilenDeger == secenekler[0])
                {
                    Console.WriteLine("deneme çalıştı");
                }

            }
        }
    }
}
