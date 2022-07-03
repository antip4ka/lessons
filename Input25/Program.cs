//S2.12. Найти площадь кольца по заданным внешнему и внутреннему радиусам.
using System;

namespace Input25
{
    class Program
    {
        static void Main(string[] args)
        {
            string Buf1;
            string Buf2;
            Console.WriteLine("Введите внешний и внутренний радиус: ");
            Buf1 = Console.ReadLine();
            Buf2 = Console.ReadLine();
            double Rad1 = Convert.ToDouble(Buf1);
            double Rad2 = Convert.ToDouble(Buf2);

            double Square1 = Math.Pow(3.14 * Rad1, 2);
            double Square2 = Math.Pow(3.14 * Rad2, 2);
            double Square = Square1 - Square2;
            Console.WriteLine("Площадь кольца: " + Square);
        }
    }
}
