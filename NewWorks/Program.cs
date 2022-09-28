using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            bool login = false;


            if (login)
            {
                Console.WriteLine("Giriş yapıldı");
                string[] Courses = { "c#", "java", "sql", "html" };
                for (int i = 0; i < Courses.Length; i++)
                {
                    Console.WriteLine($"{i}. kurs = {Courses[i]}");
                }

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hesabınız yok ise yeni bir hesap oluşturunuz.");


                string[] AccountInfo = { "Kullanıcı Adı:", "E-mail adresiniz:", "Şifre: " };


                foreach (var item in AccountInfo)
                {
                    Console.WriteLine(item);
                }


            }
            Console.ReadLine();



        }




    }
}
