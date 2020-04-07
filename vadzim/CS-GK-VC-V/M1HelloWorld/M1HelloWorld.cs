// Mit using-Anweisungen kann ein schneller Zugriff auf externe Klassen oder Namensräume ermöglicht werden
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace: Umgebung für unser Programm
namespace M1HelloWorld
{
    // Einstiegspunkt für das Programm. Die Klasse mit der Methode Main() ist immer die Einstiegsklasse
    class M1HelloWorld
    {
        static void Main(string[] args)
        {
            // Console.OpenStandardOutput();

            // Es gibt Klassen, die für den Programmierer schon vordefiniert.     
            // Mit der Klasse Console können wir die cmd-Konsole ansprechen.
            Console.WriteLine("Hallo C#");

            // Variablen
            string varZumKurzenAufbewahrenVonText = "Buchstabensalat";

            Console.WriteLine(varZumKurzenAufbewahrenVonText);
            

            // Konsole wartet auf Klick von einer Taste
            Console.ReadKey();           

        }
    }
}
