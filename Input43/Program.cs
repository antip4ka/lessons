//S2.28. У американского писателя-фантаста Рэя Бредбери есть роман «450 градусов  по Фаренгейту».
//Какой температуре по шкале Цельсия соответствует указанное в названии значение? (См. предыдущую задачу).
using System;

namespace Input43
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Far = 450;
            double T = (Far - 32) / 1.8;
            Console.WriteLine("450 градусов по фаренгейту по русски называется: " + T);
        }
    }
}