//S2.23. Известна стоимость монитора, системного блока, клавиатуры и мыши. Сколько будут стоить 3 компьютера из этих элементов? N компьютеров?
using System;

namespace Input38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите необходимое количество компьютеров: ");
            double N = Convert.ToDouble(Console.ReadLine());

            const int Mon = 5400;
            const int Block = 22000;
            const int Klava = 1200;
            const int Mouse = 500;
            double Stoimost = N * (Mon + Block + Klava + Mouse);
            Console.WriteLine("Стоимость покупки " + N + " компьютеров " + Stoimost);
        }
    }
}
