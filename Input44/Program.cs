//S3.1 Составить программу обмена значениями двух переменных величин.
using System;

namespace Input44
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int buf = a;
            a = b;
            b = buf;
            Console.WriteLine(a + " " + b);
        }
    }
}
