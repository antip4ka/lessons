//S2.14А. Даны стороны прямоугольника.
//Найти его периметр и длину диагонали.
using System;

namespace Input29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны прямоугольника: ");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double Diag = Math.Sqrt(A * A + B * B);
            double Perimetr = A + A + B + B;
            Console.WriteLine("Периметр прямоугольника: " + Perimetr);
            Console.WriteLine("Диагональ прямоугольника: " + Diag);
        }
    }
}