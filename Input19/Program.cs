//Дан радиус окружности. Найти длину окружности и площадь круга.
using System;

namespace Input19
{
    class Program
    {
        static void Main(string[] args)
        {
            string Buf;
            Console.WriteLine("Введите радиус окружности: ");
            Buf = Console.ReadLine();
            double Radius = Convert.ToDouble(Buf);
            double Dlina = 2 * 3.14 * Radius;
            double x = 3.14 * Radius;
            double Ploshd = Math.Pow(x, 2);
            Console.WriteLine("Длина окуржности: " + Dlina);
            Console.WriteLine("Площадь круга: " + Ploshd);

        }
    }
}