using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTransportConsumer
{
    interface IMitRädern
    {
        int AnzahlRäder { get; set; }
        void Crash();
    }
}
