using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriOdevi
{
    class CustomerManager
    {

        public void CustomerAdd(Customer customer)
        {

            Console.WriteLine(customer.CustomerName + "  " + customer.CustomerSurname + " adlı müşteri sisteme eklendi..");
            Console.WriteLine("                                                                                        ");

        }

        public void CustomerList(List<Customer> customers)
        {
            foreach (var item in customers)
            {
                Console.WriteLine(item.CustomerId + " " + item.CustomerTc + " " + item.CustomerName + " " + item.CustomerSurname + " " +
                                        item.CustomerTel);

            }
            Console.WriteLine("Kişiler listelendi..");
        }

        public void CustomerRemove(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + "  " + customer.CustomerSurname + " adlı müşteri silindi..");
        }



    }
}
