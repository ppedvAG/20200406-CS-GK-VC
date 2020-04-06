using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Console
{
    class DConsole
    {
        static void Main(string[] args)
        {
            // Referenz zur Klasse Console
            // https://docs.microsoft.com/de-de/dotnet/api/system.console?view=netframework-4.8

            // ==================================================================
            Console.WriteLine("\n ### Console.WriteLine() ### ");
            // schreibt die Argumente zum Default-Output
            // bei der Konsole-App ist die cmd-Konsole
            // ein anderes Outpus könnte z.B. eine Messagebox sein
            Console.WriteLine("Ausgabe");


            // ==================================================================
            Console.WriteLine("\n ### Console.WriteLine(string, arg0, arg1) ### ");
            int Alter = 35;
            string Stadt = "Berlin";
            Console.WriteLine("Ich bin Vadzim, {0}. Ich wohne in {1}", Alter, Stadt);
            Console.WriteLine("Ich wohne in {1}, heiße Vadzim und bin {0} Jahre alt.", Alter, Stadt);


            // ==================================================================
            Console.WriteLine("\n ### Console.Write(string) ### ");
            // gibt das Argument aus und der Kursor bleibt in der gleichen Zeile stehen
            Console.Write("ausgabe von Write()");


            // ==================================================================
            Console.WriteLine("\n ### Console.ReadLine() ### ");
            //Console.Write("Geben Sie Ihren Namen ein: ");
            //string Name = Console.ReadLine();
            //Console.WriteLine("Sie heißen also {0}.", Name);


            // ==================================================================
            Console.WriteLine("\n ### Console.OutputEncoding ### ");
            Console.WriteLine("Eurozeichen: €"); // ?
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Eurozeichen mit Encoding.UTF8: €"); // €


            // ==================================================================
            Console.WriteLine("\n ### Environment.Exit() ### ");
            // beendet vorzeitig eine Konsolenanwendung
            // Environment.Exit(0);

            Console.ReadKey();
        }
    }
}
