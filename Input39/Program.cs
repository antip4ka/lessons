//S2.24. Возраст Тани — X лет, а возраст Мити — Y лет. Найти их средний возраст,
//а также определить, на сколько отличается возраст каждого ребенка от среднего значения.
using System;

namespace Input39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст Тани: ");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите возраст Мити: ");
            double Y = Convert.ToDouble(Console.ReadLine());

            double Sredniy = (X + Y) / 2;
            double N1 = X - Sredniy;
            double N2 = Y - Sredniy;
            Console.WriteLine("Средний возраст: " + Sredniy + " Таня отличается на " + N1 + " Митя отличается на " + N2);
        }
    }
}
