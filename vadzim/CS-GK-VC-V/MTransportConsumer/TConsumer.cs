using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTransportConsumer
{
    class TConsumer
    {
        static void Main(string[] args)
        {
            Transport transport = new Transport("VW", 20000, 220);
            Console.WriteLine($"transport.BeschreibeMich(): {transport.BeschreibeMich()}");

            Console.ReadKey();
        }
    }
}
