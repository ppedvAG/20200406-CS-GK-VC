using System;
using System.Collections.Generic;

namespace Demo_EntityFrameworkCore
{
    class DEFCore
    {
        public static List<Anschrift> anschriften = new List<Anschrift>();

        static void Main(string[] args)
        {
            anschriften.Add(new Anschrift { AnschriftId = 1, Adresszeile = "Hauptstraße 1", PLZ = 12345, Stadt = "Bonn" });


           var db = new KundenDbContext();

            db.Add(new Kunde { KundenId = 1, KundenName = "Max Mustermann"});
            
            Console.WriteLine("Hello World!");
        }
    }
}
