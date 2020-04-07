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
            //Übung M3 Zufallszahl
            Random generator = new Random();
            int zufallszahl = generator.Next(1, 6);
            int Eingabe;
            do
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
                Eingabe = int.Parse (Console.ReadLine());
                if (Eingabe < zufallszahl)                               
                {
                    Console.WriteLine("Ihre Zahl ist zu klein, Bitte versuchen Sie es noch einmal.");
                }
                else if (Eingabe > zufallszahl)
                {
                    Console.WriteLine("Ihre Zahl ist zu groß, Bitte versuchen Sie es noch einmal.");

                }
                else
                {
                    Console.WriteLine("Sie liegen im richtigen wertebereich");
                    
                }

                 
            } while (Eingabe != zufallszahl);
            Console.ReadKey();
        }
    }
}
