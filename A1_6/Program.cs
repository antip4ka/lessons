//A1.6. С начала суток прошло n секунд. Определить:
//а) сколько полных часов прошло с начала суток;
//б) сколько полных минут прошло с начала очередного часа;
//в) сколько полных секунд прошло с начала очередной минуты.
using System;

namespace A1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество секунд: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int Chas = n / 360;
            int Min = n / 60;
            Console.WriteLine("Прошло часов: " + Chas + " Прошло минут: " + Min + " Прошло секунд: " + n);
        }
    }
}
