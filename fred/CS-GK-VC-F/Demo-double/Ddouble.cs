using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_double
{
    class Ddouble
    {
        static void Main(string[] args)
        {

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++ 
            Console.WriteLine("\n ### double literal () ### ");
            double myDbl = 34.23;


            //+++++++++++++++++++++++++++++++++++++++++++++++++++++ 
            Console.WriteLine("\n ### double parse() ### ");
            Console.Write("Geben Sie eine Doublezahl ein: ");
            //   double input = Console.ReadLine();
            double input = double.Parse(Console.ReadLine());

            Console.WriteLine($"input: {input} ");


            Console.ReadKey();


        }
     }
}
