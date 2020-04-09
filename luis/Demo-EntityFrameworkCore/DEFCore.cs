using System;
using System.Collections.Generic;

namespace Demo_EntityFrameworkCore
{
    class DEFCore
    {
        static void Main(string[] args)
        {

            List<Anschrift> anschriften = new List<Anschrift>();
            anschriften.Add(new Anschrift { AnschriftId = 1, Adresszeile = "Hauptstr. 1", PLZ = 12345, Stadt = "Bonn" });
            using (var db = new KundenDbContext())
            {
                db.Add(new Kunde { KundenId = 1, KundenName = "Max Mustermann" });
            }
                
            Console.WriteLine("Hello World!");
        }
    }
}
