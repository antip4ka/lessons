//S2.20. Треугольник задан координатами своих вершин. Найти периметр и площадь треугольника.
using System;

namespace Input35
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
            double AB = Math.Sqrt((Math.Pow(x2, 2) - Math.Pow(x1, 2)) + (Math.Pow(y2, 2) - Math.Pow(y1, 2)));
            double BC = Math.Sqrt((Math.Pow(x3, 2) - Math.Pow(x2, 2)) + (Math.Pow(y3, 2) - Math.Pow(y2, 2)));
            double AC = Math.Sqrt((Math.Pow(x3, 2) - Math.Pow(x1, 2)) + (Math.Pow(y3, 2) - Math.Pow(y1, 2)));
            double Perimetr = AB + BC + AC;
            double Square = 0.5 * Math.Abs((x2 -x1) * (y3 - y1) - (x3 - x1) * (y2 - y1));
            Console.WriteLine("Периметр треугольника: " + Perimetr + " Площадь треугольника: " + Square);
        }
    }
}
