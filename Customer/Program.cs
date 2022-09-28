using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriOdevi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 07;
            customer1.CustomerTc = "Tc : 46066871770";
            customer1.CustomerName = "Nilos";
            customer1.CustomerSurname = "Baggins";
            customer1.CustomerTel = "05348160031";

            Customer customer2 = new Customer();
            customer2.CustomerId = 03;
            customer2.CustomerTc = "Tc: 10066871030";
            customer2.CustomerName = "Bilbo";
            customer2.CustomerSurname = "Baggins";
            customer2.CustomerTel = "05396164273";

            Customer customer3 = new Customer();
            customer3.CustomerId = 19;
            customer3.CustomerTc = "Tc : 80766971050";
            customer3.CustomerName = "Çuçi";
            customer3.CustomerSurname = "Baggins";
            customer3.CustomerTel = "05356160072";


            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);


            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerAdd(customer1);
            customerManager.CustomerList(customers);
            customerManager.CustomerRemove(customer3);

            Console.ReadLine();


        }

    }
}
