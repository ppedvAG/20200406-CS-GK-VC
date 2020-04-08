using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportmittel
{
    abstract public class Transportmittel
    {
        public string Name { get; set; }
        public int maxSpeed { get; set; }
        public int Preis { get; set; }
        public int actSpeed { get; set; }
        public bool moving { get; set; }

        public Transportmittel(string Bezeichnung, int Anschaffungspreis, int hoechstGeschwindigkeit)
        {
            Name = Bezeichnung;
            Preis = Anschaffungspreis;
            maxSpeed = hoechstGeschwindigkeit;
        }


        abstract public void Beschleunige();
        

        public virtual void StarteMotor()
        {
            moving = true;
        }

        public virtual void StopeMotor()
        {
            moving = false;
        }

        public virtual string BeschreibeDich()
        {
            return "Ich Heiße: " + Name + " ich bewege mich: " + moving + " mit Geschwindigkeit: " + actSpeed;
        }

        

    }

    public class PKW : Transportmittel, IHatRäder
    {

        public int anzahlRäder { get; set; }
        int IHatRäder.anzahlRäder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public PKW(string Bezeichnung, int Anschaffungspreis, int hoechstGeschwindigkeit, int reifenAnzahl) : base(Bezeichnung, Anschaffungspreis, hoechstGeschwindigkeit)
        {
            anzahlRäder = reifenAnzahl;
        }

        

        public override void Beschleunige()
        {
            if (actSpeed < maxSpeed)
            {
                actSpeed = actSpeed + 10;
            }
        }

        public override void StarteMotor()
        {
            actSpeed = 0;
            moving = true;
        }

        public override void StopeMotor()
        {
            actSpeed = 0;
            moving = false;
        }

        public override string BeschreibeDich()
        {
            return base.BeschreibeDich() + "und habe " + anzahlRäder + " Reifen ";
        }

        void IHatRäder.Crash()
        {
            throw new NotImplementedException();
        }
    }


    public class Schiff : Transportmittel
    {

        public int anzahlBullaugen { get; set; }

        public Schiff(string Bezeichnung, int Anschaffungspreis, int hoechstGeschwindigkeit, int WievieleBullaugen) : base(Bezeichnung, Anschaffungspreis, hoechstGeschwindigkeit)
        {
            anzahlBullaugen = WievieleBullaugen;
        }


        //public void Belade(Transport fz)
        //{
        //    if (this.Ladung == null)
        //    {
        //        this.Ladung = fz;
        //        Console.WriteLine($"Ladevorgang von '{fz.Name}' auf '{this.Name}' erfolgreich.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Ladeplatz auf  '{this.Name}' bereits durch '{this.Ladung.Name}' belegt.");
        //    }
        //}



        //public void Entlade()
        //{
        //    if (this.Ladung != null)
        //    {
        //        Console.WriteLine($"Entladevorgang von '{this.Ladung.Name}' erfolgreich.");
        //        this.Ladung = null;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"'{this.Name}' hat keine Ladung geladen.");
        //    }
        //}


        public override void Beschleunige()
        {
            if (actSpeed < maxSpeed)
            {
                actSpeed = actSpeed + 2;
            }
        }


        public override void StopeMotor()
        {
            
            while (actSpeed > 0)
            {

                System.Threading.Thread.Sleep(500);
                actSpeed = actSpeed - 1;


            }
            moving = false;
        }


        public override string BeschreibeDich()
        {
            return base.BeschreibeDich() + "und habe " + anzahlBullaugen + " Bullaugen ";
        }

    }



    public class Flugzeug : Transportmittel, IEnumerable
    {

        public int anzahlSitzplätze { get; set; }

        public List<string> Passagierliste { get; set; }

        public string this[int i]
        {
            get { return Passagierliste[i]; }
            set { Passagierliste[i] = value; }
        }

        public Flugzeug(string Bezeichnung, int Anschaffungspreis, int hoechstGeschwindigkeit, int WievieleSitzplätze) : base(Bezeichnung, Anschaffungspreis, hoechstGeschwindigkeit)
        {
            anzahlSitzplätze = WievieleSitzplätze;
            Passagierliste = new List<string>();
        }

        public override void Beschleunige()
        {
            if (actSpeed < maxSpeed)
            {
                actSpeed = actSpeed + 100;
            }
        }


        public override void StopeMotor()
        {
            while (actSpeed > 0)
            {

                System.Threading.Thread.Sleep(1000);
                actSpeed = actSpeed - 1;

            }
            moving = false;
        }


        public override string BeschreibeDich()
        {
            return base.BeschreibeDich() + "und habe " + anzahlSitzplätze + " Sitzplätze ";
        }

        public IEnumerator GetEnumerator()
        {
            //return ((IEnumerable)Passagierliste).GetEnumerator();

            foreach (var item in Passagierliste)
            {
                // Mit yiel verhindern wir dass die Methode bei "return" abgebrochen wird
                yield return item;
            }
        }

    }

}
