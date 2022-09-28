using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekilOdevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Sekil sekil = new 
        }
    }
}
/*Şekil, Kare ve Daire sınıfları yazılacak
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
 

using System;

namespace Odev.SekilKareDaire
{
    class Program
    {
        static void Main(string[] args)
        {
            int birlesmisAlan;

            var d = new Daire(3);       // çap 3
            var k = new Kare(5);        // kenar 5

            birlesmisAlan = Sekil.Birlestir(d, k);
            Console.WriteLine(birlesmisAlan);       // çıkış : 52

            birlesmisAlan = Sekil.Birlestir(d, d);
            Console.WriteLine(birlesmisAlan);       // çıkış : 54

            birlesmisAlan = Sekil.Birlestir(k, k);
            Console.WriteLine(birlesmisAlan);       // çıkış : 50 
        }
    }
}*/