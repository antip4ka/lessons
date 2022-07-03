//Составить программу:
//а) вычисления значения функции y=7x2+3x+6 при любом значении x;
//б) вычисления значения функции x=12a2+7a+12 при любом значении а.
using System;

namespace Input14
{
    class Program
    {
        static void Main(string[] args)
        {
            string buf;
            Console.WriteLine("Введите х: ");
            buf = Console.ReadLine();
            double x = Convert.ToDouble(buf);
            double y = (7 * x * 2) + (3 * x) + 6;
            Console.WriteLine(y);

            string buf2;
            Console.WriteLine("Введите a: ");
            buf2 = Console.ReadLine();
            double a = Convert.ToDouble(buf2);
            double x2 = (12 * a * 2) + (7 * a) + 6;
            Console.WriteLine(x2);
        }
    }
}