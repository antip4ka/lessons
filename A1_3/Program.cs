//A1.3. Дана масса в килограммах. Найти число полных тонн в ней.
using System;

namespace A1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массу в килограммах.");
            int Mas = Convert.ToInt32(Console.ReadLine());
            int Result = Mas / 1000;
            Console.WriteLine("Число полных тонн: " + Result);
        }
    }
}
