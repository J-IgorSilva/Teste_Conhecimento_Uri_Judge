using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            // area de uma circuferencia. a=3.14159.raio*2 ponto flutuante;
            // Poderia Refatorar, Inserindo um metodo, para lote;
            double Area = 3.14159, Raio = 0.0, Lote = 0.0;

            Console.WriteLine("Digite o tamanho a ser calculado: ");
            Raio = double.Parse(Console.ReadLine());

            Console.WriteLine(Raio);

            Lote = Area * Raio * 2;

            Console.WriteLine("Seu Resultado é :" + Lote.ToString("F2"));

        }
    }
}
