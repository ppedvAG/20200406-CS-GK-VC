using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTransportConsumer
{
    class TConsumer
    {
        static void Main(string[] args)
        {
            Transport transport = new Transport("VW", 20000, 220);
            Console.WriteLine($"transport.BeschreibeMich(): {transport.BeschreibeMich()}");

            Flugzeug flugzeug = new Flugzeug("Boeing", 800, 300000000, 900);
            Console.WriteLine($"flugzeug.Passagierliste: {flugzeug.Passagierliste}");

            flugzeug.Passagierliste.Add("Max Mustermann");
            flugzeug.Passagierliste.Add("Helena Fischer");
            flugzeug.Passagierliste.Add("Falco");

            // Dank IEnumerable ist es möglich, die Instanz von Flugzeug durch zu iterieren
            foreach (var item in flugzeug)
            {
                Console.WriteLine($"item: {item}");
            }

            // Dank der Eigenschaft 'this[int i]' ist es möglich, die Instanz über array-ähnliche Syntax anzusprechen
            Console.WriteLine($"flugzeug[2]: {flugzeug[2]}");

            Console.ReadKey();
        }
    }
}
