using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien2Lekcja8
{
    public static class Zadanie3
    {
        public static void WyswietlZadanie()
        {
            int a = 1;
            int b = 0;
            int c = 0;
            do
            {
               
             
                    Console.WriteLine($"{c}, ");
                c = a + b;
                a = b;
                b = c;




            } while (a <= 10000);

        }

    }

}
