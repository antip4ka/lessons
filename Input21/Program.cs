//S2.8. Известны объем и масса тела. Определить плотность материала этого тела.
using System;

namespace Input21
{
    class Program
    {
        static void Main(string[] args)
        {
            string Buf1;
            string Buf2;
            Console.WriteLine("Введите объем и массу тела: ");
            Buf1 = Console.ReadLine();
            Buf2 = Console.ReadLine();
            double volume = Convert.ToDouble(Buf1);
            double mass = Convert.ToDouble(Buf2);
            double density = mass / volume;
            Console.WriteLine("Плотность тела равна: " + density);
        }
    }
}