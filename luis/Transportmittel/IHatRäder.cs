using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportmittel
{
    interface IHatRäder
    {
        int anzahlRäder { get; set; }

        void Crash();
    }
}
