using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_double
{
    class Ddouble
    {
        static void Main(string[] args)
        {
            // ==================================================================
            Console.WriteLine("\n ### double literal ### ");
            double myDbl = 34.23;


            // ==================================================================
            Console.WriteLine("\n ### double.Parse(string) ### ");
            Console.Write("Geben Sie eine double-Zahl ein: ");
            // double input = Console.ReadLine();
            double input = double.Parse(Console.ReadLine());

            Console.WriteLine($"input: {input}");
            // Bei Zahl mit Punkt wird der Punkt getrimt
            // Bei Zahl mit Komma hat es funktioniert
            string dblAsString = "34,23";
            double strToDbl = double.Parse(dblAsString);
            Console.WriteLine($"strToDbl: {strToDbl}");


            // ==================================================================
            Console.WriteLine("\n ### double.Parse(var, CultureInfo) ### ");
            string dblAsString2 = "34.23";
            double dblFromPointNr = double.Parse(dblAsString2, System.Globalization.CultureInfo.InvariantCulture); // *todo
            Console.WriteLine($"dblFromPointNr: {dblFromPointNr}");

            Console.ReadKey();
        }
    }
}
