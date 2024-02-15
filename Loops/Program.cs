using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Döngüler

            ForEachLoop();

            //WhileLoop();

            //ForLoop();

            Console.ReadLine();
        }

        private static void ForEachLoop()
        {
            string[] cities = { "Ankara", "İstanbul", "İzmir", "Bursa", "Antalya" };
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            int number = cities.Length;
            while (number > 0)
            {
                if (cities[number-1] == "Ankara")
                {
                    Console.WriteLine("Ankara şehri dizide var");
                }
                else
                {
                    Console.WriteLine("Ankara şehri dizide YOK");
                }
                number--;
            }
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Number is {0}", number);
        }

        private static void ForLoop()
        {
            // 1 den 100'e kadar olan sayıları yaz
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");

            // 1 den 100'e kadar tek sayıları yaz
            for (int i = 1; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");

            // 1 den 100'e kadar çift sayıları yaz
            for (int i = 0; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
        }
    }
}
