using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int, decimal,float,enum,boolean value types
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("sayi1 -> " + sayi1);

            //arrays, class, interface referance types
            int[] sayilar1 = { 1, 2, 3 };
            int[] sayilar2 = { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine("sayilar1[0] -> " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "AAAAAA";
            person2 = person1;

            person1.FirstName = "BBBBBB";
            Console.WriteLine(person2.FirstName);


            Customer customer1 = new Customer();
            customer1.FirstName = "TestKullanıcısı";
            customer1.CreditCardNumber = "23456789";
            Employee employee = new Employee();
            employee.FirstName = "Calisan Eleman";

            Person person3 = customer1;

            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            personManager.Add(person2);
            personManager.Add(person1);
            personManager.Add(customer1);
            personManager.Add(employee);

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    // base class : Person
    class Customer: Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee: Person
    {
        public int EmplojyeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
