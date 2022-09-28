using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekilOdevi

    
     /*   class Kare : Sekil
        {

            public int kenar { get; set; }

            public Kare(int kenar) //: base(kenar * kenar)
            {
                base.alanBilgisi = kenar * kenar;
            }

            public override int Alan(int kenarUzunlugu)
            {
                this.alanBilgisi = kenarUzunlugu * kenarUzunlugu;
                return this.alanBilgisi;
            }
        }
        class Daire : Sekil
        {

            const int piSayisi = 3;

            public int Cap { get; set; }

            public Daire(int cap) //: base(piSayisi * cap * cap)
            {
                base.alanBilgisi = piSayisi * cap * cap;

            }

            public override int Alan(int cap)
            {
                this.alanBilgisi = piSayisi * cap * cap;
                return this.alanBilgisi;
            }
        }
    }

abstract class Sekil
{
    //protected Sekil(int alanBilgisi)
    //{
    //    this.alanBilgisi = alanBilgisi;
    //}

    public abstract int Alan(int kenar);


    public int alanBilgisi;



    public static int Birlestir(Sekil sekil1, Sekil sekil2)
    {
        return sekil1.alanBilgisi + sekil2.alanBilgisi;
    }



}
class Program
{
    static void Main(string[] args)
    {
        /*
            Şekil, Kare ve Daire sınıfları yazılacak
            Kare ve Daire, Sekil sınıfından türeyecek

            Kare, bir kenar uzunluğu ile oluşturulacak
            Daire, çap uzunluğu ile oluşturulacak

            Sekil sınıfında, herhangi iki şekli birleştirebilen bir metot tanımlanacak.
            Birleştirme işlemi, birleştirilen şekillerin alanlarının toplamının hesaplanması demek.

            Aşağıdaki "Main" metotda kullanım şekli gösterilmiştir.
            "Main" içine herhangi bir kod eklemesi yapılmayacak.
            "Birlestir" metodu Sekil sınıfında gerçekleştirilecek.

            Bu çalışmayı sağlayan sınıfları yazınız.

            Not: tüm işlemleri int tipinde yapınız. Pi sayısını 3 olarak kullanınız.
        */
       /* int birlestirilmisAlan;


        var kare = new Kare(5);
        var daire = new Daire(3);

        birlestirilmisAlan = Sekil.Birlestir(daire, kare);
        Console.WriteLine(birlestirilmisAlan);

        birlestirilmisAlan = Sekil.Birlestir(daire, daire);
        Console.WriteLine(birlestirilmisAlan);

        birlestirilmisAlan = Sekil.Birlestir(kare, kare);
        Console.WriteLine(birlestirilmisAlan);




    }
}*/
