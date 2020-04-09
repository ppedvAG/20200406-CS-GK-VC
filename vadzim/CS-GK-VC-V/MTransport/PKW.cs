using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTransportConsumer
{
    public class PKW : Transport, IMitRädern
    {
        // ####################################################
        // evtl. FIELDS
        // ####################################################
        // PROPERTIES 
        public int AnzahlTüren { get; set; }
        public int AnzahlRäder { get; set; }

        // ####################################################
        // CONSTRUCTORS
        public PKW(string name, int maxG, int preis, int anzTüren) : base(name, maxG, preis)
        {
            this.AnzahlTüren = anzTüren;
            this.AnzahlRäder = 4;
        }

        // ####################################################
        // METHODS
        public void Crash()
        {
            // throw new NotImplementedException();
            // this.AnzahlRäder = this.AnzahlRäder - 1;
            // this.AnzahlRäder -= 2;

            Console.WriteLine("Du hast einen Baum übersehen.");
            if (AnzahlRäder > 0)
            {
            AnzahlRäder--;
            } else
            {
                Console.WriteLine("Keine Räder mehr");
            }
        }

    }
}
