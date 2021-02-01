using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Büşra";
            customer1.Surname = "Oran";
            customer1.Id = 123456;
            customer1.PhoneNumber = 05555555511;
            customer1.Gender = "female";

            Customer customer2 = new Customer();
            customer2.Name = "Kaya";
            customer2.Surname = "Yılmaz";
            customer2.Id = 222456;
            customer2.PhoneNumber = 05555555522;
            customer2.Gender = "male";

            Customer customer3 = new Customer();
            customer3.Name = "Jeffree";
            customer3.Surname = "Star";
            customer3.Id = 333456;
            customer3.PhoneNumber = 05555555533;
            customer3.Gender = "non-binary";

            Customer customer4 = new Customer();
            customer4.Name = "Elon";
            customer4.Surname = "Musk";
            customer4.Id = 444456;
            customer4.PhoneNumber = 05555555544;
            customer4.Gender = "male";

            Customer customer5 = new Customer();
            customer5.Name = "Fahriye";
            customer5.Surname = "Evcen";
            customer5.Id = 555456;
            customer5.PhoneNumber = 05555555555;
            customer5.Gender = "female";

            Customer[] customers = new Customer[] {customer1,customer2,customer3,customer4,customer5 };

            CustomerManager cManager = new CustomerManager();

            foreach (var item in customers)
            {
                cManager.Display(item);
            }
            
        }
    }
}
