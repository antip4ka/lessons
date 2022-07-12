//A1.2. Дана масса в килограммах. Найти число полных центнеров в ней.
using System;

namespace A1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массу в килограммах.");
            int Mas = Convert.ToInt32(Console.ReadLine());
            int Result = Mas / 100;
            Console.WriteLine("Число полных центнеров. " + Result);
        }
    }
}
