using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTransportConsumer
{
    public interface IKannAndereTransportieren
    {
        Transport Ladung { get; set; }
        void Belade(Transport transport);
        void Entlade();
    }
}
