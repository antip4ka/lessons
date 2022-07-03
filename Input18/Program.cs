//Дана длина ребра куба. Найти объем куба и площадь его боковой поверхности.
using System;

namespace Input18
{
    class Program
    {
        static void Main(string[] args)
        {
            string Buf;
            Console.WriteLine("Введите длину ребра куба: ");
            Buf = Console.ReadLine();
            double a = Convert.ToDouble(Buf);
            double Ploshad = a * a;
            double Obem = a * a * a;
            Console.WriteLine("Площадь боковой поверхности "+ Ploshad);
            Console.WriteLine("Объем куба "+ Obem);
        }
    }
}