//A1.7. Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него?
using System;

namespace A1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result = 543 / 130;
            Console.WriteLine("Количество квадратов: " + Result);
        }
    }
}
