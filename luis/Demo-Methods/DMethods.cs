using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Methods
{
    class DMethods
    {
        //public Methoden sind woanders (nicht in Main) deklariert
        // Syntax
        // modifier returntype identifier(Parameter) { body }
        public static double Addiere(double a, double b, double c = 0, double d = 0)
        {
            double summe = a + b + c + d;
            return summe;
        }

        //Gleichnamige Methode mit untersciedlichen Rückgabetypen auch möglich
        public static int Addiere(int a, int b, int c, int d = 0)
        {
            int summe = a + b + c + d;
            return summe;
        }

        public static int Addiere(int a, int b, int c = 0)
        {
            int summe = a + b + c;
            return summe;
        }


        public static int AddiereBeliebigVieleForEach(params int[] summanden)
        {
            int summe = 0;
        
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


        public static int AddiereUndSubtrahierenUndMultiplizieren(int a, int b, out int differenz, out int produkt)
        {
            differenz = a - b;
            produkt = a * b;
            int summe = a + b;
            return summe;
        }


        //public static int AddiereUndSubtrahierenUndMultiplizieren(int a, int b, ref int differenz, ref int produkt)
        //{
        //    differenz = a - b;
        //    produkt = a * b;
        //    int summe = a + b;
        //    return summe;
        //}



        static void Main(string[] args)
        {
            int differenz;
            int produkt;

            
            //==================================================
            Console.WriteLine("\n ### simple call ### ");
            Console.WriteLine($"Addiere(3, 4): {Addiere(3,4)}");


            //==================================================
            Console.WriteLine("\n ### call w. optional args ### ");
            Console.WriteLine($"Addiere(3, 4, 2): {Addiere(3, 4, 2)}");


            //==================================================
            Console.WriteLine("\n ### overloads calls ### ");
            Console.WriteLine($"Addiere(3.4, 4.2): {Addiere(3.4, 4.2)}");


            //==================================================
            Console.WriteLine("\n ### Linq call ### ");
            Console.WriteLine($"Addiere(3, 4, 4, 2, 4): {Addiere(3, 4, 4, 2, 4)}");


            //==================================================
            Console.WriteLine("\n ### out call ### ");
            Console.WriteLine($"AddiereUndSubtrahierenUndMultiplizieren(3, 4, out differenz, out produkt): {AddiereUndSubtrahierenUndMultiplizieren(3, 4, out differenz, out produkt)} differenz: {differenz}, product: {produkt}");


            //==================================================
            Console.WriteLine("\n ### 2nd out call ### ");
            Console.WriteLine($"AddiereUndSubtrahierenUndMultiplizieren(differenz, produkt, ref differenz, ref produkt): {AddiereUndSubtrahierenUndMultiplizieren(differenz, produkt, out differenz, out produkt)} differenz2: {differenz}, product2: {produkt}");


            Console.ReadKey();
        }
    }
}
