//Дано вещественное число а. Пользуясь только операцией умножения, получить:
//а) a4 за две операции;
//б) a6 за три операции;
//в) a7 за четыре операции;
//г) a8 за три операции;
//д) a9 за четыре операции;
//е) a10 за четыре операции.
using System;

namespace Input46
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int a2 = a * a;
            int a4 = a2 * a2;
            int a6 = a4 * a2;
            int a7 = a6 * a;
            int a8 = a6 * a * a;
            int a9 = a6 * a * a * a;
            int a10 = a7 * a * a * a;

        }
    }
}
