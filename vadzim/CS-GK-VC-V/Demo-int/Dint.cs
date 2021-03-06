﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_int
{
    class Dint
    {
        static void Main(string[] args)
        {
            // ==================================================================
            Console.WriteLine("\n ### int literals ### ");
            int myInt1 = 4;
            int myInt2 = -5;


            // ==================================================================
            Console.WriteLine("\n ### int possible values ### ");
            Console.WriteLine($"int.MinValue: {int.MinValue}");
            Console.WriteLine($"int.MaxValue: {int.MaxValue}");


            // ==================================================================
            Console.WriteLine("\n ### int.Parse() für strings ### ");
            // kann nur eine string-Variable parsen!!!
            Console.Write("Geben Sie eine Zahl ein: ");            
            string zahlAlsString = Console.ReadLine();
            int gecastedString = int.Parse(zahlAlsString);
            Console.WriteLine($"gecastedString is int: {gecastedString is int}");
            Console.WriteLine($"gecastedString.GetType(): {gecastedString.GetType()}");            


            // ==================================================================
            Console.WriteLine("\n ### (int).kommazahl für unganze Zahlen ### ");
            double kommazahl = 34.23;
            int ganzezahl = (int)kommazahl;
            Console.WriteLine($"ganzezahl: {ganzezahl}");

            Console.ReadKey();
        }
    }
}
