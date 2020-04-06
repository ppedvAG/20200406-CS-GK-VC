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
            Console.WriteLine("\n ### double.Parse() ### ");
            Console.Write("Geben Sie eine double-Zahl ein: ");
            // double input = Console.ReadLine();
            double input = double.Parse(Console.ReadLine());

            Console.WriteLine($"input: {input}");
            // Bei Zahl mit Punkt wird der Punkt getrimt
            // Bei Zahl mit Komma hat es funktioniert
            string dblsAsString = "34,23";
            double strToDbl = double.Parse(dblsAsString);
            Console.WriteLine($"strToDbl: {strToDbl}");


            // ==================================================================
            Console.WriteLine("\n ### double.Parse(var, CultureInfo) ### ");
            //double dblFromPointNr = double.Parse(myDbl, System.Globalization.CultureInfo.InvariantCulture);
            //double dblFromPointNr = double.Parse(myDbl, System.Globalization.NumberStyles.Double);

            // *todo





            Console.ReadKey();
        }
    }
}
