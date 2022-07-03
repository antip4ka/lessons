using System;

namespace using4
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Составить программу вывода на экран числа, вводимого с клавиатуры. После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».");
            Console.WriteLine("Введите число: ");
            string text = Console.ReadLine();
            Console.WriteLine(text);
            Console.WriteLine("Вот такое число вы ввели.");
        }
    }
}