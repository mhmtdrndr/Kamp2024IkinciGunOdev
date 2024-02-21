using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();            
            customerManager._logger = new DatabaseLogger();
            customerManager.AddCustomer();
            Console.ReadLine();
        }
    }
}
