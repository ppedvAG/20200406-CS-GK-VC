using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Methods
{
    class DMethods
    {
        // public Methoden stehen in einer Klasse und sind nicht in einer anderen Methode deklariert (z.B. nicht in Main())

        // Syntax:
        // modifier returntype identifier(parameter) { body }
        public static double Addiere(double a, double b, double c = 0, double d = 0)
        {
            double summe = a + b + c + d;
            return summe;            
        }

        // Gleichnamige Methoden mit unterschiedlichen Rückgabetypen auch möglich
        public static int Addiere(int a, int b, int c = 0, int d = 0)
        {
            int summe = a + b + c + d;
            return summe;
        }

        public static int Addiere(int a, int b, int c)
        {
            int summe = a + b + c;
            return summe;
        }

        public static int AddiereBeliebigVieleForeach(params int[] summanden)
        {
            int summe = 0; // foreach nimmt keine Variablen ohne Wert.
            foreach (var item in summanden)
            {
                summe += item;
            }
            return summe;
        }

        public static int Addiere(params int[] summanden)
        {
            int summe = summanden.Sum();
            return summe;
        }


        public static int AddiereUndSubtrahiereUndMultipliziere(int a, int b, out int differenz, out int produkt)
        {
            differenz = a - b;
            produkt = a * b;
            int summe = a + b;
            return summe;
        }


        public static int AddiereUndSubtrahiereUndMultipliziereRefs(int a, int b, ref int differenz, ref int produkt)
        {
            differenz = a - b;
            produkt = a * b;
            int summe = a + b;
            return summe;
        }
        static void Main(string[] args)
        {
            // ==================================================================
            Console.WriteLine("\n ### simple call ### ");
            Console.WriteLine($"Addiere(3,4): {Addiere(3,4)}"); 


            // ==================================================================
            Console.WriteLine("\n ### call w. optional args ### ");
            Console.WriteLine($"Addiere(3, 4, 2): {Addiere(3, 4, 2)}");


            // ==================================================================
            Console.WriteLine("\n ### overloads call ### ");
            Console.WriteLine($"Addiere(3.4, 4.2): {Addiere(3.4, 4.2)}"); //*todo overload


            // ==================================================================
            Console.WriteLine("\n ### params call ### ");
            Console.WriteLine($"Addiere(3, 4, 4, 2, 4): {Addiere(3, 4, 4, 2, 4)}");


            // ==================================================================
            Console.WriteLine("\n ### out call ### ");
            Console.WriteLine($"AddiereUndSubtrahiereUndMultipliziere(3, 4, out int diff, out int prod): {AddiereUndSubtrahiereUndMultipliziere(3, 4, out int diff, out int prod)}, diff: {diff}, prod: {prod}");

            int differenz;
            int produkt;
            Console.WriteLine($"AddiereUndSubtrahiereUndMultipliziere(4, 5, out differenz, out produkt): {AddiereUndSubtrahiereUndMultipliziere(4, 5, out differenz, out produkt)}, differenz: {differenz}, produkt: {produkt}");

            int differenz2 = 3;
            int produkt2 = 4;
            Console.WriteLine($"AddiereUndSubtrahiereUndMultipliziere(4, 5, out differenz2, out produkt2): {AddiereUndSubtrahiereUndMultipliziere(4, 5, out differenz2, out produkt2)}, differenz: {differenz2}, produkt: {produkt2}");
            // funktioniert, aber die Initialisierung ist unnötig


            // ==================================================================
            Console.WriteLine("\n ### ref call ### ");
            Console.WriteLine($"{AddiereUndSubtrahiereUndMultipliziereRefs(5, 6, ref differenz2, ref produkt2)}, differenz: {differenz2}, produkt: {produkt2}");
            
            //Console.WriteLine($"{AddiereUndSubtrahiereUndMultipliziereRefs(5, 6, ref differ, ref produc)}, diff: {differ}, prod: {produc}"); 
            // fkt nicht, weil differ & produc nicht deklariert sind
            
            Console.ReadKey();
        }
    }
}
