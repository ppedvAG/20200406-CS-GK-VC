using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTransportConsumer
{
    public class Flugzeug : Transport, IKannAndereTransportieren, IMitRädern
    {
        // ####################################################
        // evtl. FIELDS
        // ####################################################
        // PROPERTIES
        public int MaxFlughöhe { get; set; }
        public int AnzahlRäder { get; set; }
        public int AktGeschw { get; set; }

        // Array<string> test = new Array<string>();

        public List<string> Passagierliste { get; set; }
        public Transport Ladung { get; set; }

        // damit können wir die Klasse iterierbar machen
        // Durch Iterieren, angewendet an der Klasse selbst, wollen wir hier die Einträge aus der Liste ausgeben
        public string this[int i]
        {
            get { return Passagierliste[i]; }
            set { Passagierliste[i] = value; }
        }


        // ####################################################
        // CONSTRUCTORS
        
        public Flugzeug(string name, int maxG, int preis, int maxFH) : base(name, maxG, preis)
        {
            this.MaxFlughöhe = maxFH;
            this.AnzahlRäder = 10;
            Passagierliste = new List<string>() { "Anna", "Kevin-Pascal", "Hannes" };
        }

        // ####################################################
        // METHODS
        public void Crash()
        {
            Console.WriteLine("Da war ein Vogel im Weg");
            this.AnzahlRäder -= 2;
            AktGeschw -= 2;
        }

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
