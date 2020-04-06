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

            Console.ReadKey();


        }
    }
}
