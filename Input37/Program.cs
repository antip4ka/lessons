//S2.22. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки,
//если купили x кг конфет, у кг печенья и z кг яблок.
using System;

namespace Input37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите X кг конфет: ");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y кг печенья: ");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Z кг яблок: ");
            double Z = Convert.ToDouble(Console.ReadLine());

            const int Konf = 250;
            const int Pech = 300;
            const int Appl = 150;

            double Sum = Konf * X + Pech * Y + Appl * Z;
            Console.WriteLine("Сумма покупки: " + Sum);
        }
    }
}
