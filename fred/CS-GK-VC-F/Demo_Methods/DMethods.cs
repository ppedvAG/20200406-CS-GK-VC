using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Methods
{
    class DMethods
    {
        //Syntax:
        // modifier returntype identifier(parameter) {body}
        public static double Addiere(double a, double b, double c=0, double d = 0)
        {
            double summe = a + b + c + d;
                return summe; 
        }

        //gleichnamige Methoden mit unterschiedlichen Rückgabetypen sind möglich
        public static int Addiere(int a, int b, int c = 0, int d = 0)
        {
            int summe = a + b + c + d;
            return summe;
        }


        public static int AddiereBeliebigVieleForeach(params int [] summanden)
        {
            int summe=0;
            //foreach nimmt keine Variablen ohne Wert
            foreach (var item in summanden)
            {
                summe += item;
            }
            return summe;
        }

        // Aufruf mit Linq, danach ist using System.Linq oben im Kopf aktiviert
        public static int Addiere(params int[] summanden)
        {

            return summanden.Sum();
            
        }

        public static int AddiereUndSubtrahiereUndMultipliziere(int a, int b, out int differenz, out int produkt)
        {
            differenz = a - b;
            produkt = a * b;
            int summe = a + b;
            return summe;
            }

        public static int AddiereUndSubtrahiereUndMultipliziereRef(int a, int b, out int differenz, out int produkt)
        {
            differenz = a - b;
            produkt = a * b;
            int summe = a + b;
            return summe;
        }

        static void Main(string[] args)
        {
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("\n ### simple call ### ");
            Console.WriteLine($"Addiere(3,4): {Addiere(3,4)}");

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("\n ### call with optional args ### ");
            Console.WriteLine($"Addiere(3,4, 2): {Addiere(3, 4, 2)}");

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("\n ### overload call ### ");
            Console.WriteLine($"Addiere(3.4, 4.2): {Addiere(3.4, 4.2)}");

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("\n ### Linq call ### ");
            Console.WriteLine($"Addiere(3, 4, 4, 2, 4): {Addiere(3, 4, 4, 2, 4)}");

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("\n ### out call ### ");
            Console.WriteLine($"(AddiereUndSubtrahiereUndMultipliziere 3, 4, out int diff, out int prod): {AddiereUndSubtrahiereUndMultipliziere(3, 4, out int diff, out int prod)}, diff: {diff}, prod: {prod}");

            int differenz;
            int produkt;
            Console.WriteLine($"(AddiereUndSubtrahiereUndMultipliziere 3, 4, out int diff, out int prod): {AddiereUndSubtrahiereUndMultipliziere(3, 4, out differenz, out produkt)}, differenz: {differenz}, produkt: {produkt}");

            int differenz2 = 3; // funktioniert aber die Initialisierung ist unnötig
            int produkt2 = 4;
            Console.WriteLine($"(AddiereUndSubtrahiereUndMultipliziere 3, 4, out int diff, out int prod): {AddiereUndSubtrahiereUndMultipliziere(3, 4, out differenz2, out produkt2)}, differenz2: {differenz2}, produkt2: {produkt2}");

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("\n ### REF call ### ");
            Console.WriteLine("$,{AddiereUndSubtrahiereUndMultipliziereRef(5, 6, ref differenz2, ref produkt2)}, differenz: {differenz2}, produkt: {produkt2}");
            //Console.WriteLine($"Addiere(3, 4, 4, 2, 4): {Addiere(3, 4, 4, 2, 4)}");

            Console.ReadKey();


        }
    }
}
