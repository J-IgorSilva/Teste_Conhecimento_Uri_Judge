using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combustível
{
    class Gasto
    {
        public int mLitro, time, speed;

        public int Viagem(double Liters)
        {
            Liters = mLitro * speed / time;
            return Viagem(Liters);
        }
    }
}
