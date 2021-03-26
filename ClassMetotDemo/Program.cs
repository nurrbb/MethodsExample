using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            customer customer1 = new customer();
            customer1.CustomerId = 342;
            customer1.ContactName = "Elizabeth Keen";
            customer1.ContactName = "Tom Keen";
            customer1.TotalBalance = 254004.87;

            customer customer2 = new customer();
            customer2.CustomerId = 343;
            customer2.CustomerName = "Katarina Rostova";
            customer2.ContactName = "Kathryn Nemec";
            customer2.TotalBalance = -2145.08;

            customer customer3 = new customer();
            customer3.CustomerId = 344;
            customer3.CustomerName = "Dembe Zuma";
            customer3.ContactName = "Marvin Gerard";
            customer3.TotalBalance = 97363.75;

            CustomerManager manage = new CustomerManager();
            manage.AddCustomer("Anna McMahon","None", 59737);
            manage.DeleteCustomer(customer2);
           
        }
    }
}
