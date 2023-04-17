using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien2Lekcja8
{ //Zamiana liczby dziesiętnej na binarną
    public static class Zadanie9
    {
        public static void WyswietlZadanie()
        {
           // double[] ciagPotegLiczbyDwa = new double[];
            double podstawa = 2;
            int liczbaPotegowa = 0;
            double wynikPotegi;
            double liczbaBinarna = 0;
            Console.Write("Podaj liczbę do zamiany na system binarny:");
            string pobraneDane = Console.ReadLine();
            int pobranaLiczba = int.Parse(pobraneDane);
     
            do //sprawdzanie max liczby potegowej dla pobranej liczby
            {
                wynikPotegi  = Math.Pow(podstawa, liczbaPotegowa);
                liczbaPotegowa++;
                
            } while (wynikPotegi <= pobranaLiczba);
            Console.Write("Wynik: ");
            for (int i = liczbaPotegowa; i>=0 ;i-- ) //Przelicznie liczby dec na bin
            {
                wynikPotegi = Math.Pow(podstawa, i);
                if (pobranaLiczba >= wynikPotegi && liczbaBinarna+wynikPotegi<=pobranaLiczba) //wyswietlanie liczby bin jako stringa
                {
                    
                    Console.Write("1");
                    liczbaBinarna = liczbaBinarna + wynikPotegi;
                }
                else 
                {
                    Console.Write("0");
                }
            }

        }

    }
}
