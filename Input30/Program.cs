//S2.15. Даны два числа. Найти их сумму, разность, произведение,
//а также частное от деления первого числа на второе.
using System;

namespace Input30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа: ");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double Sum = A + B;
            double Raz = A - B;
            double Pro = A * B;
            double Cha = A / B;
            Console.WriteLine("Сумма: " + Sum);
            Console.WriteLine("Разность: " + Raz);
            Console.WriteLine("Произведение: " + Pro);
            Console.WriteLine("Частное: " + Cha);

        }
    }
}
