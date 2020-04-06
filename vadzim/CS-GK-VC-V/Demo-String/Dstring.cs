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
            // ==================================================================
            Console.WriteLine("\n ### string literals ### ");
            Console.WriteLine("Variante 1: dopperte Anführungszeichen");
            string Alter = "fünfunddreißig";
            string Stadt = "Minsk";


            // ==================================================================
            Console.WriteLine("\n ### string possible values ### ");
            Console.WriteLine("Theoretisch könnte ein string 1,073,741,823 Zeichen lang sein");
            Console.WriteLine("\"");


            // ==================================================================
            Console.WriteLine("\n ### string operators ### ");
            Console.WriteLine("string = string + string"); // concatinate
            Console.WriteLine(Alter + Stadt is string); // True


            // ==================================================================
            Console.WriteLine("\n ### string literals ### ");
            Console.WriteLine("Variante 2: $\"some text {expression}\" - interpolated strings");
            string Satz = $"Stadt + Alter is string: {Alter + Stadt is string} und noch bisschen text { true }";
            Console.WriteLine(Satz);


            // ==================================================================
            Console.WriteLine("\n ### escape sequences ### ");
            Console.WriteLine("vor dem tab \t nach dem tab");
            Console.WriteLine("C:\\Programme\\datei.doc");


            // ==================================================================
            Console.WriteLine("\n ### string literals ### ");
            Console.WriteLine("Variante 3: @\"some text \" - verbatim strings");
            Satz = @"vor dem tab        nach dem Tab
                nach dem Zeilenumbruch";
            Console.WriteLine(Satz);


            // ==================================================================
            Console.WriteLine("\n ### string literals ### ");
            Console.WriteLine("Variante 4: $@\"some \t {expr} text \" - interpolation & verbatim strings");
            Satz = $@"vor dem tab        nach dem Tab   Stadt: {Stadt}
                nach dem Zeilenumbruch";
            Console.WriteLine(Satz);

            Console.ReadKey();

        }
    }
}
