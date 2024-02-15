using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Metods

            Add();
            Console.WriteLine(Sum1(1,2,3,4,5,6,7));

            Console.ReadLine();

        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Sum1(params int[] nums)
        {
            return nums.Sum();
        }
    }
}
