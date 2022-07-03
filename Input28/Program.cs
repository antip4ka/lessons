//S2.14. Даны основания и высота равнобедренной трапеции.
//Найти ее периметр.
using System;

namespace Input28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите основания и высоту");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double H = Convert.ToDouble(Console.ReadLine());
            double Kat = (B - A) / 2;
            double Bedro = Math.Sqrt(H * H + Kat * Kat);
            double Perimetr = Bedro + Bedro + A + B;
            Console.WriteLine("Периметр равен: " + Perimetr);
        }
    }
}
