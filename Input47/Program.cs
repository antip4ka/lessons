//S3.4. Дано вещественное число a. Пользуясь только операцией умножения, получить:
//а) a3 и a10 за четыре операции;
//б) a4 и a20 за пять операций;
//в) a5 и a13 за пять операций;
//г) a5 и a19 за пять операций;
//д) a2, a5 и a17 за шесть операций;
//е) a4, a12 и a28 за шесть операций.
using System;

namespace Input47
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int a3 = 10 * 10 * 10;
            int a10 = a3 * a3 * a3 * a;
                int a4 = 10 * 10 * 10 * 10;
                int a20 = a4 * a4 * a4 * a4 * a4;
            int a5 = a * a * a * a * a;
            int a13 = a5 * a5 * a * a * a;
                int a5 = a * a * a * a * a;
                int a19 = a5 * a5 * a5 * a * a * a;
            int a2 = a * a;
            int a5 = a2 * a2 * a;
            int a17 = a5 * a5 * a5 * a2;
                int a4 = a * a * a * a;
                int a12 = a2 * a2 * a2 * a2 * a2 * a2;
                int a28 = a12 * a4 * a4 *a4 * a2 * a2;
        }
    }
}
