using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportmittel
{
    interface IMitRaedern
    {
        int AnzahlRaeder { get; set; }
        void crash();
    }
}
