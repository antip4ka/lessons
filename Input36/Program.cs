//S2.21. Выпуклый четырехугольник задан координатами своих вершин. Найти площадь этого четырехугольника как сумму площадей треугольников.
using System;

namespace Input36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты Х и Y первой вершины: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты Х и Y второй вершины: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты Х и Y третьей вершины: ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты Х и Y четвертой вершины: ");
            double x4 = Convert.ToDouble(Console.ReadLine());
            double y4 = Convert.ToDouble(Console.ReadLine());
            double Square1 = 0.5 * Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1));
            double Square2 = 0.5 * Math.Abs((x2 - x4) * (y3 - y4) - (x3 - x4) * (y2 - y4));
            double Square = Square1 + Square2;
            Console.WriteLine(" Площадь четырехугольника: " + Square);
        }
    }
}
