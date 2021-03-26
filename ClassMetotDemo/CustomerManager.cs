using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        public void AddCustomer(string CustomerName, string CustomerContact, double TotalBalance )
        {
            Console.WriteLine("Succesfully added!");
        }
        public void DeleteCustomer(customer customers)
        {
            Console.WriteLine("Succesfully removed!");
        }
        public void ListCustomer(customer[] customers )
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer ID:" + customer.CustomerId);
                Console.WriteLine("Customer FullName: " + customer.CustomerName);
                Console.WriteLine("Contact Name: " + customer.ContactName);
                Console.WriteLine("Total Balance: " + customer.TotalBalance + "$");
            }
        }
        public void NewBalance(string balance)

        {
            Console.WriteLine("New balance: " + balance + "$");
            
        }
        public void EditCustomer(customer customers)
        {
            Console.WriteLine("Succesfully edited.");
        }
    }
}
