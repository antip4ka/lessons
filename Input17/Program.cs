//Считая, что Земля — идеальная сфера с радиусом R=6350 км, определить расстояние
//до линии горизонта от точки В с заданной высотой h=AB над Землей.
using System;

namespace Input17
{
    class Program
    {
        static void Main(string[] args)
        {
            string Buf;
            Console.WriteLine("Введите высоту АВ: ");
            Buf = Console.ReadLine();
            double h = Convert.ToDouble(Buf);
            double gipotenuza = h + 6350;
            double katet = (gipotenuza * gipotenuza)-(6350*6350);
            double rasstoyanie = Math.Sqrt(katet);
            Console.WriteLine(rasstoyanie);
        }
    }
}