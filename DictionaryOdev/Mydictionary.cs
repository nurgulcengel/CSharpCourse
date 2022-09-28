using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryOdev
{
    class Mydictionary<T>
    {
        T[] _bagginss;
        T[] tempArray;

        public Mydictionary()
        {
            _bagginss = new T[0];
        }

        public void Add(T baggins)
        {

            tempArray = _bagginss;
            _bagginss = new T[_bagginss.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                _bagginss[i] = tempArray[i];
            }


            _bagginss[_bagginss.Length - 1] = baggins;
        }
        public void Print()
        {
            foreach (var item in _bagginss)
            {
                Console.WriteLine(item);
            }
        }


        public void Count()
        {
            Console.WriteLine("Bagginsler" + " " + _bagginss.Length + " " + "kişilik mutlu bir ailedir :)");
        }

    }



}
