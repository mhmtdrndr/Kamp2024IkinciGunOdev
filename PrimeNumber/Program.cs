using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int number = 10;

            for (int i = 0; i < 30; i++)
            {
                if (isPrimeNumber(i))
                {
                    Console.WriteLine("{0} sayısı asal değildir ...", i);
                }
                else
                {
                    Console.WriteLine("{0} sayısı asal ...", i);
                }
            }


            Console.ReadLine();
        }

        private static bool isPrimeNumber(int nums)
        {
            bool result = false;
            if (nums >= 2)
            {
                for (int i = 2; i < nums; i++)
                {
                    if (nums % i == 0)
                    {
                        result = true;
                        break;
                    }
                }
            }
            else { result = true; }
            return result;

        }
    }
}
