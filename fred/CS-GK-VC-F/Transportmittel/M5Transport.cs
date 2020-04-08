using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportmittel
{
    class M5Transport
    {
        static void Main(string[] args)
        {
            PKW pKW = new PKW("Audi", 12000, 185);
            Console.WriteLine(pKW.Wasbinich());

            Schiff schiff = new Schiff("Titanic", 2500000, 40); 
            Console.WriteLine(schiff.Wasbinich());

            Flugzeug flugzeug = new Flugzeug("Propeller", 250000, 960);
            Console.WriteLine(flugzeug.Wasbinich());

            Schiff schiff1 = new Schiff("Aida Prima", 25000, 35);

            Console.WriteLine("Nun mit Listen:********************************");
            Flugzeug flugzeug1 = new Flugzeug("Boing", 250000, 980);
            Console.WriteLine($"\n flugzeug.Passagierliste: {flugzeug.Passagierliste}");

            flugzeug.Passagierliste.Add("Hans Meier");
            flugzeug.Passagierliste.Add("Sylke Winter");
            flugzeug.Passagierliste.Add("Achim Schmnitz");
            flugzeug.Passagierliste.Add("Frauke Wald");

            // Dank IEnumerable ist es möglich die Instanz von Flugzeug durch zu iterieren
            foreach (var item in flugzeug)
            {
                Console.WriteLine($"item: {item}");
            }
            //Dank der Eigenschaft  'this[int i]' ist es möglich die Instanz über array-ähnliche Syntax anzusprechen

            Console.WriteLine($"flugzeug[2]: {flugzeug[2]}");
            
            // So können keine Werte ausgegeben werden
            Console.WriteLine($"\n nOCHMAL ZUM sCHLUSS flugzeug.Passagierliste: {flugzeug.Passagierliste}");


            Console.ReadKey();
        }
    }
}
