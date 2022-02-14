using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo
{
    class Carro
    {
        public int Kilometro;
        public double Combustivel;

        public double DCarro(double gasto)
        {
            gasto = Kilometro / Combustivel;

            return gasto;
        }
        
    }
}
