using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1011
{
    class Program
    {
        static void Main(string[] args)
        {
            Esfera r;
            r = new Esfera();
            Console.WriteLine("Insira o Valor do raio ");
            r.Raio = double.Parse(Console.ReadLine());
            Console.WriteLine("O volume exato é: " + r.VolumeEsfera().ToString("F2"));
        }
    }
}
