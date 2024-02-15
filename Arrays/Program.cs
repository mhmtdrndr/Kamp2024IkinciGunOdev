using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3] { "Mehmet", "Gürkan", "Özlem" };

            //string[] students2 = { "Jonh", "Alice", "Rai" };

            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}

            // Çok boyutlu diziler
            // Türkiye'nin bölgleri ve o bölgenin 3 şehir

            string[,] regions = new string[7,3]
            {
                {"İstanbul","Bursa","Edirne"},
                {"Ankara","Kırıkkale","Konya"},
                {"Trabzon","Samsun","Ordu"},
                {"Muş","Bingöl","Van"},
                {"Antalya","Mersin","Isparta"},
                {"İzmir","Denizli","Aydın"},
                {"Diyarbakır","Hakkari","Şanlıurfa"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine(" --- ");
            }

            Console.ReadLine();
        }
    }
}
