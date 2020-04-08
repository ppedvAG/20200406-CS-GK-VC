using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTransportConsumer
{
    public class Schiff : Transport, IKannAndereTransportieren
    {
        // ####################################################
        // evtl. FIELDS
        // ####################################################
        // PROPERTIES
        
        public enum SchiffsTreibstoff
        {
            Diesel,
            Dampf,
            Wind,
            Muskelkraft
        }
        public SchiffsTreibstoff Treibstoff { get; set; }
        public Transport Ladung { get; set; }

        // ####################################################
        // CONSTRUCTORS

        public Schiff(string name, int maxG, int preis, SchiffsTreibstoff treibstoff) : base(name, maxG, preis)
        {
            this.Treibstoff = treibstoff;
        }

        // ####################################################
        // METHODS

        public void Belade(Transport transport)
        {
            if (this.Ladung == null)
            {
                this.Ladung = transport;
                Console.WriteLine($"Ladevorgang von '{transport.Name}' auf '{this.Name}' erfolgreich.");
            }
            else
            {
                Console.WriteLine($"Ladeplatz auf  '{this.Name}' bereits durch '{this.Ladung.Name}' belegt.");
            }
        }

        public void Entlade()
        {
            if (this.Ladung != null)
            {
                Console.WriteLine($"Entladevorgang von '{this.Ladung.Name}' erfolgreich.");
                this.Ladung = null;
            }
            else
            {
                Console.WriteLine($"'{this.Name}' hate keine Ladung gehabt.");
            }
        }

    }
}
