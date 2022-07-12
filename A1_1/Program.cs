//A1.1. Дано расстояние в сантиметрах. Найти число полных метров в нем.
using System;

namespace A1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расстояние в сантиметрах.");
            decimal Ras = Convert.ToDecimal(Console.ReadLine());
            decimal Result = Ras / 100;
            Console.WriteLine("Ваше расстояние в метрах " + Result);
        }
    }
}
