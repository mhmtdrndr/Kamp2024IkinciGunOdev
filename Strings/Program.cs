using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is AAA BBB";

            var result = sentence.Clone();

            sentence = "My name is CCC DDD";

            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
