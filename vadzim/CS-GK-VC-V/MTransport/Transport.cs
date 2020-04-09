using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTransportConsumer
{
    public class Transport
    {
        // ####################################################
        // evtl. FIELDS
        // ####################################################
        // PROPERTIES
        // ####################################################
        // CONSTRUCTORS
        // ####################################################
        // METHODS
        //Datentypen und Konstanten
        public enum TransportZustand { Fahrend, Stehend }

        //Eigenschaften und Felder
        public string Name { get; private set; }
        public int Preis { get; set; }
        public int MaximalGeschwindigkeit { get; private set; }
        private int aktuelleGeschwindigkeit;
        public int AktuelleGeschwindigkeit
        {
            get { return aktuelleGeschwindigkeit; }
            private set
            {
                if (value <= this.MaximalGeschwindigkeit)
                {
                    aktuelleGeschwindigkeit = value;
                }
            }
        }
        public TransportZustand Zustand { get; set; }

        //Konstruktoren
        public Transport(string name, int preis, int maximalGeschwindigkeit)
        {
            this.Name = name;
            this.Preis = preis;
            this.MaximalGeschwindigkeit = maximalGeschwindigkeit;
            this.Zustand = TransportZustand.Stehend;
            this.AktuelleGeschwindigkeit = 0;
        }

        //Methoden
        public int Beschleunigen(int km)
        {
            if (AktuelleGeschwindigkeit < MaximalGeschwindigkeit && Zustand == TransportZustand.Fahrend)
            {
                AktuelleGeschwindigkeit += km;
            }
            else
            {
                AktuelleGeschwindigkeit = MaximalGeschwindigkeit;
            }
            return AktuelleGeschwindigkeit;
        }
        public void StarteMotor()
        {
            if (Zustand == TransportZustand.Fahrend)
            {
                this.AktuelleGeschwindigkeit += 5;
            }
        }        

        public void StoppeMotor()
        {
            this.Zustand = TransportZustand.Fahrend;
        }

        public void Parke()
        {
            this.Zustand = TransportZustand.Stehend;
            this.AktuelleGeschwindigkeit = 0;
        }

        public string BeschreibeMich()
        {
            return $"{Name} ({Preis} Euro): Maximale Geschwindigkeit: {MaximalGeschwindigkeit} km/h | Zustand: {Zustand}| Mom. Geschwindigkeit: {AktuelleGeschwindigkeit}";
        }
    }
}
