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


            Console.ReadKey();
        }
    }
}
