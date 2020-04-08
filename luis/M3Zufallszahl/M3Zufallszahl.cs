using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3Zufallszahl
{
    class M3Zufallszahl
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int zufallszahl = generator.Next(1, 6);

            Console.WriteLine("\n Bitte erraten Sie die Zufallszahl zwischen 1 und 5");
            int rateVersuch = int.Parse(Console.ReadLine());

            do
            {
                if (rateVersuch > zufallszahl)
                {
                    Console.WriteLine("\n Sie liegen über der Zufallszahl, versuchen Sie es noch einmal");
                    rateVersuch = int.Parse(Console.ReadLine());
                }
                else if (rateVersuch < zufallszahl)
                {
                    Console.WriteLine("\n Sie liegen unter der Zufallszahl, versuchen Sie es noch einmal");
                    rateVersuch = int.Parse(Console.ReadLine());
                }
            } while (rateVersuch != zufallszahl);

            Console.WriteLine("\n Das ist richtig, Sie haben es geschaft!");

            Console.ReadKey();
        }
    }
}
