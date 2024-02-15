using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirsName = "AAAAAA";
            customer1.LastName = "BBBBBB";
            customer1.City = "Ankara";

            Customer customer2 = new Customer
            {
                Id = 2,
                FirsName = "DDD",
                LastName = "EEEE",
                City = "İzmir"
            };

            customerManager.Add(customer1);
            customerManager.Add(customer2);

            customerManager.GetAll();

            Console.ReadLine();
        }
    }
}
