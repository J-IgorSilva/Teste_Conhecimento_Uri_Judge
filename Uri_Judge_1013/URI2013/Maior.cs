using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI2013
{
    class Maior
    {
        public int A, B, C;
        public  int NumeroMaior()
        {
            if (A > B)
                Console.WriteLine("O Mario e´A: " + A);
            if (B > C)
            {
                Console.WriteLine("Maior é B" + B);
            }
            else
            {
                Console.WriteLine("O maior é C:" + C);
            }
            return 0;
        }
    }
}
