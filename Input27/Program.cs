// Даны два числа. Найти среднее арифметическое и
// среднее геометрическое их  модулей.
using System;

namespace Input27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа: ");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            A = Math.Abs(A);
            B = Math.Abs(B);
            double Arifm = (A + B) / 2;
            double Geome = Math.Sqrt(A * A + B * B);
            Console.WriteLine("Cреднее арифметическое: " + Arifm);
            Console.WriteLine("Среднее геометрическое: " + Geome);
        }    
    }
}
