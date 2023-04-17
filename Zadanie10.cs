using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien2Lekcja8
{
    public static class Zadanie10 // poszukanie najmniejszej wspólnej wielokrotności dla 2 podanych liczb
    {
        public static void WyswietlZadanie()
        {
            bool sukces = false;
            Console.Write($"Wprowadzone pierwszą liczbę:");
            int pierwszaLiczba = int.Parse(Console.ReadLine());
            Console.Write($"Wprowadzone drugą liczbę:");
            int drugaLiczba = int.Parse(Console.ReadLine());

            int maxLiczba = pierwszaLiczba * drugaLiczba;
            for (int i = 1; i <= maxLiczba; i++)
            {
                int y = pierwszaLiczba * i;
                for (int j = 1; j <= maxLiczba; j++)
                {
                    int x = drugaLiczba * j;

                    if (y == x && (!sukces))
                    {
                        Console.WriteLine($"Najmniejsza wspólna wielokrotność wynosi: {x}");
                        sukces = true;
                    }
                }
            }
        }

    }
}
