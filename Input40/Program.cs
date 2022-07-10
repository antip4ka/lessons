//S2.25. Два автомобиля едут навстречу друг другу с постоянными скоростями V1 и  V2 км/час.
//Определить, через какое время автомобили встретятся, если расстояние между ними было S км.
using System;

namespace Input40
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
            double T = S / (V1 + V2);
            Console.WriteLine("Время через которое встретятся автомобили: " + T);
        }
    }
}
