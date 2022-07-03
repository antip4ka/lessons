// Даны катеты прямоугольного треугольника. Найти его гипотенузу.
using System;

namespace Input23
{
    class Program
    {
        static void Main(string[] args)
        {
            string Buf1;
            string Buf2;
            Console.WriteLine("Введите катеты треугольника");
            Buf1 = Console.ReadLine();
            Buf2 = Console.ReadLine();
            double a = Convert.ToDouble(Buf1);
            double b = Convert.ToDouble(Buf2);
            double c = Math.Pow(a,2)+Math.Pow(b,2);
            double g = Math.Sqrt(c);
            Console.WriteLine("Гипотенуза равна: " + g);
        }
    }
}