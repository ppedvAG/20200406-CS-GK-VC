using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportmittel
{
    public class Transport
    {
        public string sName;
        public int iMaxGeschw;
        public int iPreis;
        private int iAktuell;
        public bool bSteht;

        public Transport(string name, int Preis, int MaxGeschw)
        {
            sName = name;
            iPreis = Preis;
            iMaxGeschw = MaxGeschw;


        }

        public static int Erhoehe(int iMaxGeschw, int iAktuell)
        {
            if (iAktuell < iMaxGeschw)
                iAktuell++;
            return iAktuell;

        }
        public static bool changeMove(bool bSteht)
        {
            bSteht = !bSteht;

            return bSteht;


        }

        public virtual string Wasbinich()
        {
            return ($" Ich bin ein: {sName}, koste: {iPreis}");

        }
    }
    public class PKW : Transport, IMitRaedern
    {
        public PKW(string name, int Preis, int MaxGeschw) : base(name, Preis, MaxGeschw)
        {
        }

        public string Navi { get; set; }
        public int AnzahlRaeder { get; set; }

        public void crash()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Du hast einen Baum übersehen");
            if (AnzahlRaeder > 0)
            {
                AnzahlRaeder--;
            } else
            {
                Console.WriteLine("Keine Räedr mehr");
            }

        }

        public override string Wasbinich()
        {
            return ($" Ich bin ein: {sName}, koste: {iPreis} und {Navi}");

        }



    }

    class Schiff : Transport, IKannAndereTransportieren
    {
        //Fields
        //Properties
        //Construktoren
        
        public Schiff(string name, int Preis, int MaxGeschw) : base(name, Preis, MaxGeschw)
        {
        }

        public string Wartung { get; set; }
        public Transport Ladung { get; set; }
        //Methoden
        public void Belade(Transport transport)
        {
            if (this.Ladung == null)
            {
                this.Ladung = transport;
                Console.WriteLine($"Ladevorgang von '{transport.sName}' auf '{this.sName}' erfolgreich.");
            }
            else
            {
                Console.WriteLine($"Ladeplatz auf  '{this.sName}' bereits durch '{this.Ladung.sName}' belegt.");
            }
        }



        public void Entlade()
        {
            if (this.Ladung != null)
            {
                Console.WriteLine($"Entladevorgang von '{this.Ladung.sName}' erfolgreich.");
                this.Ladung = null;
            }
            else
            {
                Console.WriteLine($"'{this.sName}' hat keine Ladung geladen.");
            }
        }

    }
    class Flugzeug : Transport, IKannAndereTransportieren, IMitRaedern, IEnumerable 
    {
    
        public int flughoehe { get; set; }
        public Transport Ladung { get; set; }
        public int AnzahlRaeder { get; set;}
        public List<string> Passagierliste { get; set; }

        //damit können wir eine Klasse iterierbar machen
        // durch Iterieren
        public string this[int i]
        {
            get { return Passagierliste[i]; }
            set { Passagierliste[i] = value; }
        }


        public Flugzeug(string name, int Preis, int MaxGeschw) : base(name, Preis, MaxGeschw)
        {
            Passagierliste = new List<string>();
        }
        public void Belade(Transport transport)
        {
            if (this.Ladung == null)
            {
                this.Ladung = transport;
                Console.WriteLine($"Ladevorgang von '{transport.sName}' auf '{this.sName}' erfolgreich.");
            }
            else
            {
                Console.WriteLine($"Ladeplatz auf  '{this.sName}' bereits durch '{this.Ladung.sName}' belegt.");
            }
        }

        public void crash()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Da waren Vögel im Weg");
        }

        public void Entlade()
        {
            if (this.Ladung != null)
            {
                Console.WriteLine($"Entladevorgang von '{this.Ladung.sName}' erfolgreich.");
                this.Ladung = null;
            }
            else
            {
                Console.WriteLine($"'{this.sName}' hat keine Ladung geladen.");
            }
        }

        public IEnumerator GetEnumerator()
        {
            //return ((IEnumerable)Passagierliste).GetEnumerator();
            foreach (var item in Passagierliste)
            {
                //Mit yield verhindern wir, dass die Methode bei return abgebrochen wird
                yield return item;

            }
        }
    }
    public interface IKannAndereTransportieren
    {
        Transport Ladung { get; set; }
        void Belade(Transport transport);
        void Entlade();
    }
}
