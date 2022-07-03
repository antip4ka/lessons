//S2.10. Составить программу решения линейного уравнения ax+b=0 (a ≠ 0).
using System;

namespace Input23
{
    class Program
    {
        static void Main(string[] args)
        {
            string Buf1;
            string Buf2;
            Console.WriteLine("Введите коэфициэнты a и b: ");
            Buf1 = Console.ReadLine();
            Buf2 = Console.ReadLine();
            double a = Convert.ToDouble(Buf1);
            double b = Convert.ToDouble(Buf2);
            double x = (-1 * b) / a;
            Console.WriteLine(x);
        }
    }
}
