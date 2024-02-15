using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class CustomerManager
    {
        List<Customer> customers = new List<Customer>();
        public CustomerManager() { 
            // yapıcı blok   
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine("{0} isimli müşteri eklendi.", customer.FirsName);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("{0} isimli müşteri güncellendi.", customer.FirsName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("{0} isimli müşteri silindi.", customer.FirsName);
        }

        public void GetAll() {
            foreach (var customer in customers)
            {
                Console.WriteLine("{0} {1} ",customer.FirsName, customer.LastName);
            }
        }
    }
}
