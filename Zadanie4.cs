using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien2Lekcja8
{
    public static class Zadanie4 //Wyświetla piramidę z zakresu podanego przez użytkownika
    {
        public static void WyswietlZadanie()
        {
            Console.WriteLine("Podaj liczbę końcową ciągu: ");
            string wynik = Console.ReadLine();

            int a = Int32.Parse(wynik);
            int b = 1;
            int c = 1;
            string DaneDoWyswietlenia = "";

            do
            {
                DaneDoWyswietlenia = "";
                for (int i = 1; i <= b; i++)
                {
                    if (c <= a)
                    {
                        DaneDoWyswietlenia = DaneDoWyswietlenia + $"{c} ";
                    }
                    c++;
                   
                }
               b++;
                Console.WriteLine(DaneDoWyswietlenia);
                

            } while (c < a);
        }
    }
}
