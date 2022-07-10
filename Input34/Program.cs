//S2.19. Даны основания равнобедренной трапеции и угол при
//большем основании. Найти площадь трапеции.
using System;

namespace Input34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите основания и угол трапеции");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());
            double Square = (((B * B) - (A * A)) * Math.Tan(C)) / 4;
            Console.WriteLine("Площадь трапеции: " + Square);
        }
    }
}
