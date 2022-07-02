using System;

namespace Input3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string text = Console.ReadLine();
            Console.WriteLine("Вы ввели число: " + text);
            Console.ReadLine();
        }
    }
}