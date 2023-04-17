using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien2Lekcja8
//Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków.
{
    public static class Zadanie8
    {
        public static void WyswietlZadanie()
        {
            string pobraneDane = "Abcdefg";
            Console.WriteLine($"Wprowadzone dane: {pobraneDane} ");
            Console.Write("Odwrócone dane: ");

            for (int i = pobraneDane.Count() - 1; i >= 0; i--)
            {
                Console.Write(pobraneDane.ElementAt(i));
            }
        }

    }
}
