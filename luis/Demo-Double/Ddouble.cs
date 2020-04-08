using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Double
{
    class Ddouble
    {
        static void Main(string[] args)
        {

            //===================================================
            Console.WriteLine("\n ### double literal ### ");
            double myDbl = 34.23;


            //===================================================
            Console.WriteLine("\n ### double.Parse() ### ");
            Console.Write("Geben Sie eine doubel-Zahl ein: ");
            double input = double.Parse(Console.ReadLine());

            
            //===================================================
            Console.WriteLine($"input: {input}");
            //Bei Eingabe mit Punkt wird der Punkt weggetrimmt
            //Bei Eingabe mit Komma hat es funktioniert
            string dblAsString = "34,23";
            double strToDbl = double.Parse(dblAsString, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine($"strToDbl: {strToDbl}");


            ////===================================================
            //Console.WriteLine("\n ### double.Parse(var, CultureInfo) ### ");
            //double dblFromPointNr = double.Parse(myDbl, System.Globalization.CultureInfo.InvariantCulture);
            //double dblFromPointNr = double.Parse(myDbl, System.Globalization.NumberStyles.);



            Console.ReadKey();



        }
    }
}
