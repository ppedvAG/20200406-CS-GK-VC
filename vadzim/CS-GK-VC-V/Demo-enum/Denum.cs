using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_enum
{
    class Denum
    {
        // dürfen nicht in den Methoden definiert werden
        enum Pizzagröße { Klein, Mittel, Groß, Family };

        static void Main(string[] args)
        {
            // ==================================================================
            Console.WriteLine("\n ### enums syntax ### ");
            // siehe oben


            // ==================================================================
            Console.WriteLine("\n ### using enums ### ");
            Pizzagröße pizzaGr = Pizzagröße.Mittel;
            Console.WriteLine($"ich hab eine {pizzaGr}-Pizza genommen.");


            // ==================================================================
            Console.WriteLine("\n ### casting of enums ### ");
            Pizzagröße pizzaGr2 = (Pizzagröße)3;
            Console.WriteLine($"- Und ich hab eine {pizzaGr2}-Pizza genommen.");


            Console.ReadKey();

        }
    }
}
