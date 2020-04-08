//Mit using wird ein Schnellzugriff auf externe Klassen oder Namensräume ermöglicht
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace sind Umgebungen oder Sammlungen für Klassen
namespace M1HelloWorld
{
    // Einstiegspunkt für das Programm. Die Klasse mit der Methode Main() ist immer die Einstiegsklasse
    class M1HelloWorld
    {
        static void Main(string[] args)
        {
            // Es gibt Klassen die für den Programmierer schon vordefiniert sind
            // Mit der Methode Console wird die cmd-Konsole in Windows angesprochen
            Console.WriteLine("Hello C#");

            // Variablen
            string varZumKurzenAufbewahrenVonText = "Buchstabensalat";

            // über cw <Tab> <Tab> ist die kurzform für Console.WriteLine
            Console.WriteLine(varZumKurzenAufbewahrenVonText);

            // Mit der Methode ReadKey wartet die Console auf eine Eingabe vom User
            Console.ReadKey();

        }
    }
}
