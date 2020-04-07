using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Minirechner
{
    class M2Minirechner
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie eine Integerzahl ein: ");
            int zahl1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie nun eine double Zahl ein: ");
            double zahl2 = double.Parse(Console.ReadLine());
           // int zahl3 = zahl1 + zahl2;
            double zahl4 = zahl1 + zahl2;
            // Console.WriteLine("Das ganzzahlige Ergebnis ist ", zahl3);
            Console.WriteLine("Das genauere Ergebnis ist {0}", zahl4);
            Console.WriteLine($" {Math.Max(zahl1,zahl2)}/{Math.Min(zahl1,zahl2)}={Math.Max(zahl1, zahl2)/ Math.Min(zahl1, zahl2)}");



            Console.ReadKey();







        }
    }
}
