using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1011
{
    class Esfera
    {
        public double Raio;
        public double Volume;
        public double pi = 3.14;

        public double VolumeEsfera()
        {
            return (4.0 * pi *Raio*Raio*Raio / 3);
        }

    }
}
