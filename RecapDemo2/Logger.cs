using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    public class Logger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Default");
        }
    }
}
