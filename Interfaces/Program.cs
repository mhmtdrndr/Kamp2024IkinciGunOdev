using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Demo();
            //InterfacesIntro();

            ICustomerDal[] customerDals = { new SQLServerCustomerDal(), new OracleCustomerDal() };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SQLServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();

            Student student = new Student
            {
                Id = 1,
                FirstName = "Test",
                LastName = "Testtt",
            };

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Test Customer",
                LastName = "Deneme",
                Address = "Ankara"
            };

            personManager.Add(customer);
            personManager.Add(student);
        }

        interface IPerson {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer: IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person) {
                Console.WriteLine(person.FirstName + " Added!");
            }
        }
    }
}
