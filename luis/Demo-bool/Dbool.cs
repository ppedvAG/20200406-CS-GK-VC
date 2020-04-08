using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_bool
{
    class Dbool
    {
        static void Main(string[] args)
        {
            //===================================================
            Console.WriteLine("\n ### bool literals & possible values ### ");
            Console.WriteLine("true / false");


            //===================================================
            Console.WriteLine("\n ### bool operators ### ");
            bool myB1 = true;
            bool myB2 = false;
            bool myB3 = true;

            //===================================================
            Console.WriteLine("\n ### bool operators: == ### ");
            Console.WriteLine(myB1 == myB2);

            //===================================================
            Console.WriteLine("\n ### bool operators: && ### ");
            // AND
            Console.WriteLine(myB1 == myB2 && myB1 == myB3);

            //===================================================
            Console.WriteLine("\n ### bool operators: || ### ");
            // OR
            Console.WriteLine(myB1 == myB2 || myB1 == myB3);

            //===================================================
            Console.WriteLine("\n ### bool operators: ^ ### ");
            // XOR
            Console.WriteLine(myB1 == myB2 ^ myB1 == myB3);

            Console.ReadKey();
        }
    }
}
