using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien2Lekcja8
{
    public static class Zadanie2
    {
        public static void WyswietlZadanie()
        {
            int a = 0;
          
            do
            {
               
                if (a%2 ==0)
                {
                    Console.WriteLine($"Liczba {a} jest parzysta");    
                }
                a++;


            } while(a<=100);

        }

    }
}
