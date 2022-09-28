using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odevlerim
{
    class Program
    {
        static void Main(string[] args)
        {
            Belge belge1 = new Belge();
            belge1.BelgeOlusturma("Bilgi İşlem Müdürlüğü","kırmızı");
            belge1.BelgeGuncelleme("Modüllerin geliştirilmesi");
            belge1.BelgeOnaylama();
            belge1.BelgeGonderme();
            Console.WriteLine("---------------------------------------------");
            Belge belge2 = new Belge();
            belge2.BelgeOlusturma("hdgfgfdjgdj", "sarı", "jfgvujfgdjh");
            belge2.BelgeGuncelleme("bbbbbbbbbbbbbbbbb");
            belge2.BelgeGonderme();
            Console.WriteLine("---------------------------------------------");
            Belge belge3 = new Belge();
            belge3.BelgeOlusturma("Bilgi İşlem Müdürlüğü", "kırmızı");
            belge3.BelgeGuncelleme("Modüllerin geliştirilmesi");
            belge3.BelgeOnaylama();
            belge3.BelgeOnayGeriAlma();
            belge3.BelgeGonderme();
            Console.ReadKey();

           

        }       
    }
}
