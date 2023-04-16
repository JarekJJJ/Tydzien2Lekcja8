using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien2Lekcja8
{
    public static class Zadanie7
    // Napisz program, który dla liczby zadanej przez użytkownika narysuje
    // diament o krótszej przekątnej o długości wprowadzonej przez użytkownika
    // i wg wzoru:
    // Zamorduje kogoś za te zadanie !!! 3 godziny a takie oczywiste :)

    {
        public static void WyswietlZadanie()
        {
            Console.WriteLine("Podaj długość przekątnej diamentu : ");
            string dlugoscPrzekatnej = Console.ReadLine();
            int a = Int32.Parse(dlugoscPrzekatnej);


            for (int i = 0; i <= a; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 1; j <= a / 2 - i / 2; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k < i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

            }
            for (int i = a - 2; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    for (int j = 1; j <= a / 2 - i / 2; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k < i; k++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }

            }





        }

    }
}
