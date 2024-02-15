using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            // Constructor bir class dan instance oluşturulduığunda çalışan bloktur. Yapıcı blok anlamına da gelir. 
            Customer customer1 = new Customer(1, "Deneme", "DenemeDDDD","Ankara");
            customers.Add(customer1);
            Customer customer2 = new Customer { Id = 2, FirstName = "Test", LastName = "TestTTTTTTT", City = "İstanbul" };
            customers.Add(customer2);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }


            Console.ReadLine();
        }
    }

    class Customer
    {

        //defalult
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı...");
        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
