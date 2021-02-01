using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Enter a customer name: ");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Enter a customer surname: ");
            customer.Surname = Console.ReadLine();
            Console.WriteLine("Enter a customer phone number: ");
            customer.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter a customer ID number: ");
            customer.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer's gender: ");
            customer.Gender = Console.ReadLine();


        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Customer {0} {1} is deleted", customer.Name, customer.Surname);
        }

        public void Display(Customer customer)
        {
            Console.WriteLine("------Customer Information------");
            Console.WriteLine("Name: " + customer.Name + "\nSurname: " + customer.Surname + "\nUser Id: " + customer.Id + "\nGender: " + customer.Gender);
        }

    }
}
