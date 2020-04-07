using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //______________________________________________
            Console.WriteLine("\n ### Console.Writeline() ### ");
            // schreibt Argumente zum Default Output
            //bei der Konsole App ist das die CMD KOnsole
            //ein anderers Output könnte eine Message Box sein
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("\n ### Console.Writeline(string, arg0, arg1) ### ");

            int Alter = 58;
            string Stadt = "Haan";
            Console.WriteLine(" Ich bin Fred {0}. Ich wohne in {1}", Alter, Stadt);
            Console.WriteLine(" Ich wohne in {1}, heiße Fred und bin {0} Jahre alt", Alter, Stadt);
          

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("\n ### Console.Write(string) ### ");
            //gibt das Argument aus und edr Cursor bleibt in der gleichen Zeile
            Console.Write(" Ausgabe von Write()");


            //+++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("\n ### Console.Readlinne() ### ");
            Console.Write("Geben Sie Ihren Namen ein: ");
            string Name = Console.ReadLine();
;
            Console.WriteLine(" Sie heißen also {0}. ", Name);

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("\n ### Console.OutputEncoding  ### ");
            Console.WriteLine("Eurozeiche: €");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Eurozeiche: €"); //mit Eurozeichen

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("\n ### Environment.Exit()  ### ");
            Environment.Exit(0); //vorzeitiges Verlassen des Programms


            Console.ReadKey();
        }
    }
}
