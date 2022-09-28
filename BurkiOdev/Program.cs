using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurkiOdev
{
    class Program
    {
        static void Main(string[] args)
        {   Menu menu = new Menu();
            Console.WriteLine("Sayı ya da metin giriniz");
            int sayi;
            string metin;
            sayi = int.Parse(Console.ReadLine());
            menu.Menux();
            Console.ReadLine();

        }
    }
}
