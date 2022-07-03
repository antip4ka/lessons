//S2.18. Даны основания и высота равнобедренной трапеции.
//Найти периметр трапеции.
using System;

namespace Input33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите основания и высоту");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double H = Convert.ToDouble(Console.ReadLine());
            double Katet = (B - A)  /  2;
            double Bedro = Math.Sqrt(Katet * Katet + H * H);
            double Perimetr = Bedro + Bedro + A + B;
            Console.WriteLine("Периметр трапеции: " + Perimetr);
        }

    }
}
