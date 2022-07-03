//Дан радиус окружности. Найти ее диаметр.
using System;

namespace Unput16
{
    class Program
    {
        static void Main(string[] args)
        {
            string Buf;
            Console.WriteLine("Введите радиус окружности: ");
            Buf = Console.ReadLine();
            double radius = Convert.ToDouble(Buf);
            double diametr = radius * 2;
            Console.WriteLine(diametr);
        }
    }
}