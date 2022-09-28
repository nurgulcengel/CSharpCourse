using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {

                if (isPrimeNumber(-13))
                {
                    Console.WriteLine("Sayi asaldir...");
                }
                else { Console.WriteLine("Sayi asal değildir ..."); }
            }


            static bool isPrimeNumber(int sayi)
            {
                bool asalMi = true; // asal ise true

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        asalMi = false;
                    }

                }

                return asalMi;

            }








        }

    }
}
