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

            //===================================================
            Console.WriteLine("\n ### string literals ### ");
            Console.WriteLine("Variante 1: doppelte Anführungszeichen");
            string Alter = "fünfunddreizig";
            string Stadt = "Minsk";

            //===================================================
            Console.WriteLine("\n ### string possible values ### ");
            Console.WriteLine("Theoretisch könnte eine String 1,073,741,823 Zeichen lang sein");


            //===================================================
            Console.WriteLine("\n ### string operators ### ");
            Console.WriteLine("string = string + string");  //concatinate
            Console.WriteLine(Alter + Stadt);


            //===================================================
            Console.WriteLine("\n ### string operators ### ");
            Console.WriteLine("Variante 2: $\"some text {expression}\" - interpolated Strings");
            string Satz = $"Stadt + Alter is a string: {Alter + Stadt is string} und noch ein bisschen Text {true}";
            Console.WriteLine(Satz);


            //===================================================
            Console.WriteLine("\n ### escape sequences ### ");
            Console.WriteLine("vor dem tab \t nach dem tab");
            Console.WriteLine("C:\\Programme\\datei.doc");


            //===================================================
            Console.WriteLine("\n ### string literals ### ");
            Console.WriteLine("Variante 3: @\"some text \" - verbatim strings");
            Satz = @"vor dem tab    nach dem tab
                    nach dem Zeilenumbruch (und den Tabs)";
            Console.WriteLine(Satz);


            //===================================================
            Console.WriteLine("\n ### string literals ### ");
            Console.WriteLine("Variante 4: $@\"some \t {expr} text \" - interpolation & verbatim strings");
            Satz = $@"vor dem tab    nach dem tab   Stadt: {Stadt}
                    nach dem Zeilenumbruch (und den Tabs)";
            Console.WriteLine(Satz);


            Console.ReadKey();

        }
    }
}
