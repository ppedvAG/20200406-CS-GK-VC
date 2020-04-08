using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportmittel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Transportmittel Mofa = new Transportmittel("Moped", 350, 25);

            //Mofa.StarteMotor();
            //Mofa.Beschleunige();
            //Mofa.Beschleunige();
            //Mofa.Beschleunige();
            //Mofa.Beschleunige();

            //Console.WriteLine(Mofa.BeschreibeDich());



            PKW Herby = new PKW("VW", 3500, 520, 4);

            Herby.StarteMotor();
            Herby.Beschleunige();
            Herby.Beschleunige();
            Herby.Beschleunige();
            Herby.Beschleunige();

            Console.WriteLine(Herby.BeschreibeDich());

            Herby.StopeMotor();

            Console.WriteLine(Herby.BeschreibeDich());



            Schiff Moby = new Schiff("MS Moby Dick", 250000, 120, 98);

            Console.WriteLine(Moby.BeschreibeDich());

            Moby.StarteMotor();
            Moby.Beschleunige();
            Moby.Beschleunige();
            Moby.Beschleunige();
            Moby.Beschleunige();
            Moby.StopeMotor();

            Console.WriteLine(Moby.BeschreibeDich());

            System.Threading.Thread.Sleep(5000);

            Console.WriteLine(Moby.BeschreibeDich());



            Flugzeug Fly = new Flugzeug("Airbus 380 423489", 1000000, 780, 112);

            Fly.StarteMotor();
            Fly.Beschleunige();
            Fly.Beschleunige();
            Fly.Beschleunige();
            Fly.Beschleunige();
            Fly.StopeMotor();

            Console.WriteLine(Fly.BeschreibeDich());

            System.Threading.Thread.Sleep(5000);

            Console.WriteLine(Fly.BeschreibeDich());


            Console.ReadKey();
        }
    }
}
