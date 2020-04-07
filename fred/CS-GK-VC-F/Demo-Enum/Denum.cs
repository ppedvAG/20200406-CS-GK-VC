using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Enum
{
    class Denum
    {

        // dürfen nicht in den Methoden definiert werden 
        enum Pizzagröße { KLein, Mittel, Groß, Family };
        static void Main(string[] args)
        {


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++ 
        Console.WriteLine("\n ### enum syntax ### ");
           
          

        Console.WriteLine("\n ### using enum ### ");
            Pizzagröße pizzaGr = Pizzagröße.Mittel;
        Console.WriteLine($"ich habe eine {pizzaGr}-Pizza genommen.");


            //+++++++++++++++++++++++++++++++++++++++++++++++++++++ 
            Console.WriteLine("\n ### casting of enums ### ");
            Pizzagröße pizzaGr2 = (Pizzagröße)3;
            Console.WriteLine($" - Und ich hab eine {pizzaGr2}-Pizza genommen.");

            Console.ReadKey();







        }
    }
}
