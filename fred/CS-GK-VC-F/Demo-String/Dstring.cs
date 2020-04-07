using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_String
{
    class Dstring
    {
        static void Main(string[] args)
        {
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("\n ### string literals() ### ");
            Console.WriteLine("Variante 1: doppelte anführungszeichen");
            string Alter = "achtundfünfzig";
            string Stadt = "Minsk";


            //+++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("\n ### string possible values() ### ");
            Console.WriteLine("Theoretisch könnte ein String 1,073,741,823 Zeichen lang sein");

            Console.WriteLine("\"");


            //+++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("\n ### string operators ### ");
            Console.WriteLine("string = string + string"); //concatinate
            Console.WriteLine(Alter + Stadt is string); // Variablenüberprüfung string true, z.B. int false


            //+++++++++++++++++++++++++++++++++++++++++++++++++++++ Variante 2
            // Hier kann beliebig Text und Variablen gemischt werden, auch Integer - wird von Vadzim empfohlen
            Console.WriteLine("\n ### string literals() ### ");            
            Console.WriteLine("interpolated strings Variante 2: $\"some text {expression}\" - interpolated strings");
            int Nummer1 = 15;
            string Satz = $"Stadt + Alter is string: {Alter + Stadt is string} und noch {Nummer1} ein bisschen text {true} ";
            Console.WriteLine(Satz);

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("\n ### escape sequences ### ");
            Console.WriteLine("vor tab \t nach dem tab");
            Console.WriteLine("C:\\Programme\\datei.doc");


            //+++++++++++++++++++++++++++++++++++++++++++++++++++++ Variante 3
            Console.WriteLine("\n ### string literals() ### ");
            Console.WriteLine("Variante 3: @\"some text \" - verbatim strings");
            Satz = @"vor dem tab   nach dem tab
                nach dem Zeilenumbruch";
            Console.WriteLine(Satz);



            //+++++++++++++++++++++++++++++++++++++++++++++++++++++ Variante 4
            Console.WriteLine("\n ### string literals() ### ");
            Console.WriteLine("Variante 4: $@\"some text \" - interpolation & verbatim strings");
            Satz = $@"vor dem tab   nach dem tab  Stadt: {Stadt}
                nach dem Zeilenumbruch";
            Console.WriteLine(Satz);

            Console.ReadKey();
        }
    }
}
