using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            Mydictionary<string> mydictionary = new Mydictionary<string>();
            mydictionary.Add("Frodo Baggins");
            mydictionary.Add("Bilbo Baggins");
            mydictionary.Add("Çuçi Baggins");
            mydictionary.Add("Kuki Baggins");

            mydictionary.Print();
            mydictionary.Count();

            Console.ReadLine();


        }

        
    }
}
