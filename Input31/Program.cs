//S2.16. Даны длины сторон прямоугольного параллелепипеда.
//Найти его объем и площадь боковой поверхности.
using System;

namespace Input31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны параллелепипеда:");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());
            double Square = A * B;
            double Volume = A * B * C;
            Console.WriteLine("Площадь боковой поверхности: " + Square);
            Console.WriteLine("Объем параллелепипеда: " + Volume);
        }
    }
}
