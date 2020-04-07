using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.@int
{
    class Program
    {
        static void Main(string[] args)
        {
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++ 
            Console.WriteLine("\n ### int literals ### ");
            int myINt1 = 4;
            int myINt2 = -5;


            //+++++++++++++++++++++++++++++++++++++++++++++++++++++ 
            Console.WriteLine("\n ### int possible values ### ");
            Console.WriteLine($"int.MinValue: {int.MinValue}");
            Console.WriteLine($"int.MinValue: {int.MaxValue}");

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++ 
            Console.WriteLine("\n ### int.Parse() ### ");
            Console.Write("Geben Sie eine Zahl ein: ");
            string zahlAlsString = Console.ReadLine();
            int gecastedString = int.Parse(zahlAlsString);
            Console.WriteLine($"gecastedString is int: {gecastedString is int}");
            Console.WriteLine($"gecastedString.GetType(): {gecastedString.GetType()}");

            Console.WriteLine("Nächste Möglichkeit");
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++ 
            Console.WriteLine("\n ### (int)Kommazahl () ### ");
            double kommazahl = 34.23;
            int ganzezahl = (int)kommazahl;
            Console.WriteLine($"ganzezahl: {ganzezahl}");


            Console.ReadKey();








        }
    }
}
