using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien2Lekcja8
{
    public static class Zadanie5 // Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
    {
        public static void WyswietlZadanie()
        {
           for(int i=1;i<=20 ;i++ )
            {
                Console.WriteLine($"{i} do potęgi 3 = {Math.Pow(i,3)}");
            }

        }

    }
}
