using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVeriables
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Value Types
            //Console.Write("Hello World!");

            int number1 = 2147483647; //int 32 bit yer kaplar - tam sayı tutar
            long number2 = 2147483648; //long 64 bit yer kaplar - tam sayı tutar
            short number3 = 32467; //short 16 bit yer kaplar
            byte number4 = 255; //0-255 arasında 8 bitlik yer kaplar
            double number5 = 10.4; // double 64 bit yer kaplar - ondalıklı sayı tutar
            decimal number6 = 10.4M; // 
            bool condition = true; // true yada false değer tutar
            char character = 'A'; // tek bir karakter tutar

            Console.WriteLine("Number1 is, " + number1);
            Console.WriteLine("Number2 is, " + number2);
            Console.WriteLine("Number3 is, " + number3);
            Console.WriteLine("Number4 is, " + number4);
            Console.WriteLine("Character is, " + character);
            Console.WriteLine("Character is, " + (int)character); // (int) karakterin ascii kodunu yazar
            Console.WriteLine(Days.Friday);

            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday, Tuesdday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
