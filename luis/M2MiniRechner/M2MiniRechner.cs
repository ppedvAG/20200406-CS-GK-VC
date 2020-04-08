using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2MiniRechner
{
    class M2MiniRechner
    {
        static void Main(string[] args)
        {

            int myInt;
            double myDbl;

            Console.WriteLine("\n Geben Sie eine Integer-Zahl ein");
            myInt = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Geben Sie eine Double-Zahl ein");
            myDbl = double.Parse(Console.ReadLine());

            double Ergebniss = myInt + myDbl;
            int intErgebniss = (int)Ergebniss;

            Console.WriteLine($"\n Die Zahlen addiert ergeben als Integer: {Ergebniss}");
            
            Console.WriteLine($"\n Die Zahlen addiert ergeben als Double: {intErgebniss}");


            double größereDurchKleinere = Math.Max(myInt, myDbl) / Math.Min(myInt, myDbl);

            Console.WriteLine($"\n Die größere durch die kleiner geteilt ergibt: {größereDurchKleinere}");




            Console.ReadKey();

        }
    }
}
