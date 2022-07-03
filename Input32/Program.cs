//S2.17. Известны координаты на плоскости двух точек.
//Составить программу вычисления расстояния между ними.
using System;

namespace Input32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты двух точек");
            double X1 = Convert.ToDouble(Console.ReadLine());
            double Y1 = Convert.ToDouble(Console.ReadLine());
            double X2 = Convert.ToDouble(Console.ReadLine());
            double Y2 = Convert.ToDouble(Console.ReadLine());
            double Ras = Math.Sqrt(Math.Pow((X2 - X1),2) + Math.Pow((Y2 - Y1),2));
            Console.WriteLine("Расстояние между точками:" + Ras);
        }
    }
}
