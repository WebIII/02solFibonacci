using System;

namespace Fibonacci
{
    internal static class Program
    {
        private static void Main()
        {
            //Console.WriteLine("Rij van Fibonnaci");
            //Console.WriteLine("Geef het volgnummer op van het getal dat moet berekend worden");
            //int volgnr = int.Parse(Console.ReadLine());

            const int AantalGetallen = 1000;
            int[] _fibonacci = VulArrayMetFibonacciGetallen(AantalGetallen);
            int volgnr = 0;
            while (volgnr < 1 || volgnr > AantalGetallen)
            {
                Console.WriteLine("Geef het volgnummer (1.." + AantalGetallen + ") van het getal op dat moet berekend worden");
                volgnr = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Het getal is {0}", _fibonacci[volgnr - 1]);

            // Console.WriteLine("Het getal is {0}", BerekenFibonacciZonderArray(volgnr));
            Console.ReadLine();
        }

        private static int[] VulArrayMetFibonacciGetallen(int aantalGetallen)
        {
            int[] fibonacci = new int[aantalGetallen];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < aantalGetallen; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            return fibonacci;
        }

        //private static int BerekenFibonacciZonderArray(int volgNummer)
        //{
        //    int getal1 = 0;
        //    int getal2 = 1;
        //    int getal = 0;
        //    switch (volgNummer)
        //    {
        //        case 0:
        //            getal = getal1;
        //            break;
        //        case 1:
        //            getal = getal2;
        //            break;
        //        default:
        //            {
        //                for (int i = 3; i <= volgNummer; i++)
        //                {
        //                    getal = getal1 + getal2;
        //                    getal1 = getal2;
        //                    getal2 = getal;
        //                }
        //                break;
        //            }
        //    }
        //    return getal;
        //}
    }
}

