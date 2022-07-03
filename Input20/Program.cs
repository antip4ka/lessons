//Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.
using System;

namespace Input20
{
    class Program
    {
        static void Main(string[] args)
        {
            string Buf;
            string Buf2;
            Console.WriteLine("Введите 2 целых числа: ");
            Buf = Console.ReadLine();
            Buf2 = Console.ReadLine();
            double Num1 = Convert.ToDouble(Buf);
            double Num2 = Convert.ToDouble(Buf2);
            double Arifmet = (Num1 + Num2) / 2;
            double Geometr = Math.Sqrt(Num1 * Num2);
            Console.WriteLine("Среднее арифметическое: " + Arifmet);
            Console.WriteLine("Среднее геометрическое: " + Geometr);
        }
    }
}