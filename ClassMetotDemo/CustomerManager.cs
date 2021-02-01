using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {

        }

        public void DeleteCustomer(Customer customer)
        {

        }

        public void Display(Customer customer)
        {
            Console.WriteLine("------Customer Information------");
            Console.WriteLine("Name: " + customer.Name + "\nSurname: " + customer.Surname + "\nUser Id: " + customer.Id + "\nGender: " + customer.Gender);
        }

    }
}
