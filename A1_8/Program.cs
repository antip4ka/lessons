//A1.8. Дано целое число k (1 ≤ k ≤ 365). Присвоить целочисленной величине n значение 1, 2, …, 6 или 0
//в зависимости от того, на какой день недели (понедельник, вторник, …, субботу или воскресенье) приходится k-й день года, в котором 1 января:
//а) понедельник;
//б) вторник;
//в) d - й день недели(если 1 января — понедельник, то d = 1, если вторник — d= 2, …, если воскресенье — d= 7).
using System;

namespace A1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату: месяц, день, год.");
            int Month = Convert.ToInt32(Console.ReadLine());
            int Day = Convert.ToInt32(Console.ReadLine());
            int Year = Convert.ToInt32(Console.ReadLine());
            int a = (14 - Month)/12;
            int y = Year - a;
            int m = Month + 12 * a - 2;
            int Day_of_Week = (7000 + (Day + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12)) % 7;
            if (Day_of_Week == 0)
            {
                Console.WriteLine("Это Воскресенье!");
            }
            else if (Day_of_Week == 1)
            {
                Console.WriteLine("Это Понедельник!");
            }
            else if (Day_of_Week == 2)
            {
                Console.WriteLine("Это Вторник!");
            }
            else if (Day_of_Week == 3)
            {
                Console.WriteLine("Это Среда!");
            }
            else if (Day_of_Week == 4)
            {
                Console.WriteLine("Это Четверг!");
            }
            else if (Day_of_Week == 5)
            {
                Console.WriteLine("Это Пятница!");
            }
            else
            {
                Console.WriteLine("Это Суббота!");
            }
        }
    }
}
