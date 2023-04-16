using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien2Lekcja8
{
    public static class Zadanie1
    {
        public static void WyswietlZadanie()
        {
            bool wynik = true;
            for (int a = 0; a <= 100; a++)
            {
                wynik = true;
                for (int i = 2; i * i <= a; i++)
                {
                    if (a % i == 0 && a >= 2)
                    {
                        wynik = false; break;
                    }

                }
                if (wynik && a >= 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Liczba {a} jest liczbą pierwszą ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Liczba {a} nie jest liczbą pierwszą ");
                }
            }

        }

    }
}
