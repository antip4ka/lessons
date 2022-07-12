//A1.4. Дано расстояние в метрах. Найти число полных километров в нем.
using System;

namespace A1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расстояние в метрах.");
            int Ras = Convert.ToInt32(Console.ReadLine());
            int Result = Ras / 1000;
            Console.WriteLine("Число полных километров: " + Result);
        }
    }
}
