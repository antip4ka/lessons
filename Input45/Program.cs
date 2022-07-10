//S3.2. Cоставить программу обмена значениями трех переменных величин а, b, c по
//следующим двум схемам:
//а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
//б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
using System;

namespace Input45
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int c = 4;
            int buf = a;
            a = b;
            b = c;
            c = buf;
            Console.WriteLine(a + " " + b + " " + c);
        }
    }
}
