//S2.2. Дана сторона квадрата. Найти его периметр.
using System;

namespace Input15
{
    class Program
    {
        static void Main(string[] args)
        {
            string buf;
            Console.WriteLine("Введите размер стороны квадрата");
            buf = Console.ReadLine();
            double a = Convert.ToDouble(buf);
            double perimetr = a * 4;
            Console.WriteLine(perimetr);
        }
    }
}