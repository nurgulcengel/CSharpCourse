using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplamSayi = sayilariTopla(15, 25);
            sayiyiEkranaYazdir(5);
        }
        static int sayilariTopla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        static void sayiyiEkranaYazdir(int sayi3)
        {
            Console.WriteLine(sayi3);
        }

        static string metinleriBirlestir(string bilbob)
        {
            string ask = bilbob + " Nilosu sever";
            return ask;
            Console.ReadLine();
            //--------------------------------------------------
            int[] bilbob = new int[3];
            bilbo[0] = 10;
            bilbo[1] = 20;
            bilbo[2] = 30;

            string[] bilbo1 = new string[3] { "Frodo", "Sam", "Marry" };


            double[] bilbo2 = { 23.5, 24.43, 25.67 };

            for (int i = 0; i < bilbo.Length; i++)
            {
                Console.WriteLine(bilbo[i]);
            }

            int[] sayilar = new int[100];


            for (int i = 0; i < sayilar.Length; i++)
            {
                int j = i + 1;
                sayilar[i] = j;
            }

            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }




        }

    }
}


