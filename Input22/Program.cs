// S2.9. Известны количество жителей в государстве и площадь его территории.
// Определить плотность населения в этом государстве.
using System;

namespace Input22
{
    class Program
    {
        static void Main(string[] args)
        {
            string Buf1;
            string Buf2;
            Console.WriteLine("Введите количество жителей и площадь государства");
            Buf1 = Console.ReadLine();
            Buf2 = Console.ReadLine();
            double Kol = Convert.ToDouble(Buf1);
            double Square = Convert.ToDouble(Buf2);
            double Density = Kol / Square;
            Console.WriteLine("Плотность населения в государстве: " + Density);

        }
    }
}
