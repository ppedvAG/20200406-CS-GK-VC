using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_bits
{
    class Dbits
    {
        static void Main(string[] args)
        {

            // in SPS lässt es sich leict über int.2 ermitteln

            // gesucht wird nach dem dritten Bit im Integer

            int myInt1 = 0b_0000_0000_0000_0000_0000_0000_0000_1011;
            int myInt2 = 0b_0000_0000_0000_0000_0000_0000_0000_0100;

            var bit3ByInt1 = (myInt1 & (1 << 2)) != 0; // False, also an der dritten Stelle steht eine Null
            Console.WriteLine($"bit3ByInt1: {bit3ByInt1}");
            var bit3ByInt2 = (myInt2 & (1 << 2)) != 0;
            Console.WriteLine($"bit3ByInt2: {bit3ByInt2}");

            //0001 - 1
            //0010 - 2
            //0011 - 3
            //0100 - 4
            //0101 - 5
            //0110 - 6
            //0111 - 7
            //1000 - 8

            int myInt3 = 3;
            int myInt4 = 4;

            var bit3ByInt3 = (myInt3 & (1 << 2)) != 0;
            Console.WriteLine($"bit3ByInt3: {bit3ByInt3}");
            var bit3ByInt4 = (myInt4 & (1 << 2)) != 0;
            Console.WriteLine($"bit3ByInt4: {bit3ByInt4}");


            Console.ReadKey();

            // https://stackoverflow.com/questions/4854207/get-a-specific-bit-from-byte
            // https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators

        }
    }
}
