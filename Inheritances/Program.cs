using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances
{
    class Program
    {
        static void Main(string[] args)
        {

            Person[] people =
            {
                new Customer{FirstName = "Test"}, new Student{FirstName = "Deneme"}
            };

            foreach (var item in people)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer: Person
    {
        public string City { get; set; }
    }

    class Student: Person
    {
        public string Department { get; set; }
    }
}
