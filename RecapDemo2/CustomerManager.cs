using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    public class CustomerManager
    {
        public ILogger _logger { get; set; }
        public void AddCustomer()
        {
            Console.WriteLine("Customer Added!");
            _logger.Log();
        }
    }
}
