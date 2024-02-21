using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ArrayListDemo();

            //ListDemo();



            Console.ReadLine();
        }

        private static void ListDemo()
        {
            //List -> tip güvenli. hangi veri tipi ile çalışılacaksa o veri tipinin yazılması gerekir.
            List<string> cities = new List<string>();
            cities.Add("İstanbul");
            cities.Add("Ankara");
            //cities.Add(2); -> hata verir

            List<Customer> customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Tets"},
                new Customer {Id = 2, Name = "Deneme"}
            };            

            customers.AddRange(new Customer[2]
            {
                new Customer{ Id = 3, Name = "Keriman" },
                new Customer{ Id = 4, Name = "Koluman"}
            });

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name);
            }

            Customer customer1 = new Customer { Id = 5, Name = "Hakan" };
            customers.Add(customer1);


            Console.WriteLine(cities.Contains("ankara")); //Contains liste içinde elemanın olup olmadığını T/F şeklinde verir
            Console.WriteLine(customers.Contains(customer1));

            var index = customers.IndexOf(customer1);
            Console.WriteLine("index = {0}",index);

            var count = customers.Count; // listenin içerisindeki eleman sayısını verir
            Console.WriteLine(count);

            //customers.Clear(); // listeyi temizler.

        }

        private static void ArrayListDemo()
        {
            // ArrayList - çalıştığımız nesnede özellikle bir veri tipi yoksa ArrayList kullanılabilir. (TypeSafe yoksa)

            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            cities.Add("İzmir");
            cities.Add(1);
            cities.Add('A');

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
        }

        class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
