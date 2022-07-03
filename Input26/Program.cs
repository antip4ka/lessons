//S2.13.  Даны катеты прямоугольного треугольника. Найти его периметр.
using System;

namespace Input26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите катеты треугольника: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Pow(a,2) + Math.Pow(b,2);
            double g = Math.Sqrt(c);
            double perimetr = a + b + g;
            Console.WriteLine("Периметр треугольника: " + perimetr);
        }
    }
}
