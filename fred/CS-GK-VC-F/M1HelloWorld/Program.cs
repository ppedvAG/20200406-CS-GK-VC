// Mit using Anweisungen kann ein schneller ZUgriff auf exerne Klassen  oder Namensräume ermöglicht werden (aus dem .Net Framework Core oder so)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace ist der Rahmen für die Namensgebung, keine doppelten Namen verwenden
namespace M1HelloWorld
{
   //Einstiegspunkt für das Programm - Die Klasse mit der Methode Main ist immer die Einstiegsklasse
    class M1HelloWorld
    {
        static void Main(string[] args)
        {
            // Es gibt Klassen, de für den Programmierer schon vordefiniert sind.
            // Mit der Klasse Console können wir die cmd-KOnsole ansprechen
            Console.WriteLine("Hallo C#");

            //Variablen
            string varZumKurzenAufbewahrenVonText = "Buchstabensalat";
           
            Console.WriteLine(varZumKurzenAufbewahrenVonText);
            Console.ReadKey();
         }
    }
}
