//S2.26. Два автомобиля едут друг за другом с постоянными скоростями V1 и  V2 км/час (V1>V2).
//Определить, какое расстояние будет между ними через 30 минут после того, как первый автомобиль опередил второй на S км.
using System;

namespace Input41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите V1: ");
            double V1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите V2: ");
            double V2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите S: ");
            double S = Convert.ToDouble(Console.ReadLine());

            if (V1 > V2)
            {
                double S2 = (0.5 * (V1 - V2))+ S;
                Console.WriteLine("Расстояние между автомобилями через 30 минут после того как первый обгонит второй на " + S + " равна " + S2);
            }
            else
            {
                Console.WriteLine("Решений нет.");
            }
        }
    }
}
