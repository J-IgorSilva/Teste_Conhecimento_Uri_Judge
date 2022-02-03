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
            // ler 4 valores inteiros e calcular a diferenca
            // formula da diferenca = (a*b-c*d)
            int a, b, c, d, DIFERENCA;
            Console.WriteLine("Insira quatro numeros: "); // ENTRADA DE DADOS DO USUARIO
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());    // LEITURA E ARMAZENAMENTO DE VALORES
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            // CALCULO RESULTADO DOS VALORES INSERIDOS

            DIFERENCA = (a * b - c * d);

            Console.WriteLine("A DIFERENÇA ATUAL É: " + DIFERENCA);
            Console.ReadLine();
        }
    }
}
