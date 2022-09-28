using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductCategoryId = 10;
            product1.ProductName = "Laptop";
            product1.ProductPrice = 10.000;
            product1.ProductDescription = "Dell Marka Laptop";

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductCategoryId = 10;
            product2.ProductName = "Desktop";
            product2.ProductPrice = 15.000;
            product2.ProductDescription = "Toshiba Marka Desktop";


            Product product3 = new Product();
            product3.ProductId = 3;
            product3.ProductCategoryId = 20;
            product3.ProductName = "Akıllı Telefon";
            product3.ProductPrice = 14.000;
            product3.ProductDescription = "Iphone 11 Pro";


            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);


            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].ProductId + " " + products[i].ProductCategoryId + " " + products[i].ProductName + " "
                                      + products[i].ProductPrice + " " + products[i].ProductDescription);
            }
            Console.WriteLine("-----------------------for loop list örneği---------------------");



            foreach (var item in products)
            {
                Console.WriteLine(item.ProductId + " " + item.ProductCategoryId + " " + item.ProductName + " " + item.ProductPrice +
               " " + item.ProductDescription);
            }
            Console.WriteLine("----------------------Foreach ile List döndüm-----------------------------------");


            Product[] products1 = { product1, product2, product3 };
            for (int i = 0; i < products1.Length; i++)
            {
                Console.WriteLine(products1[i].ProductId + " " + products1[i].ProductCategoryId + " " + products1[i].ProductName + " "
                                     + products1[i].ProductPrice + " " + products1[i].ProductDescription);
            }

            Console.WriteLine("----------------------For loop bile Array döndüm-------------------------------");



            int n = 0;
            while (n < products.Count)
            {
                Console.WriteLine(products[n].ProductId + " " + products[n].ProductCategoryId + " " + products[n].ProductName + " "
                                     + products[n].ProductPrice + " " + products[n].ProductDescription);
                n++;

            }
            Console.WriteLine("------While Loop ile List döndüm--------------------------");
            Console.ReadLine();



        }
    }
}
