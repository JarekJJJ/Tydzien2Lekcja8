using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien2Lekcja8
{
    public static class Zadanie6 //
        //Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
        // 1 + ½ + 1/3 + ¼ itd.
    {
        public static void WyswietlZadanie()
        {
            double wynik = 0;
            for (double x = 0; x <=20 ; x++)
            {
                wynik = x;
                for (double i = 1; i <= 20; i++)
                {
                    wynik = wynik + 1 / i;
                    
                }
                Console.WriteLine($"Suma ze wzoru dla liczby {x} = {wynik}");
                wynik = 0;
            }
            

        }

    }
}
