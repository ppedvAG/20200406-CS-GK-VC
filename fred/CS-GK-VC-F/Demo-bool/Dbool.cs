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
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++ 
            Console.WriteLine("\n ### bool literals & possible values () ### ");
            Console.WriteLine("true / false ");


            //+++++++++++++++++++++++++++++++++++++++++++++++++++++ 
            Console.WriteLine("\n ### bool operators () ### ");
            bool myB1 = true;
            bool myB2 = false;
            bool myB3 = true;

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++ 
            Console.WriteLine("\n ### bool operators == ### ");
            Console.WriteLine(myB1==myB2);


            //+++++++++++++++++++++++++++++++++++++++++++++++++++++ AND
            Console.WriteLine("\n ### bool operators && ### ");
            Console.WriteLine(myB1 == myB2 && myB1 == myB3); // false mit True ergibt False

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++ 
            Console.WriteLine("\n ### bool operators || ### "); // OR Bedingung
            Console.WriteLine(myB1 == myB2 || myB1 == myB3); // false mit True ergibt True 


            //+++++++++++++++++++++++++++++++++++++++++++++++++++++ 
            Console.WriteLine("\n ### bool operators ^ ### "); // XOR Bedingung - nur 1 Bedingung darf zutreffen
            Console.WriteLine(myB1 == myB2 ^ myB1 == myB3); // false mit True ergibt True 



            Console.ReadKey();

        }
    }
}
