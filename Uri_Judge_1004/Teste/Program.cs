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
            // PROSUTO SIMPLES---1004-URI
            int a = 0, b = 0, produto;
            Console.WriteLine("Digite o valor de a: "); 
            // INTERAÇÃO COM O USUARIO
            a = int.Parse(Console.ReadLine()); 
            // ARMAZENANDO VALOR NA VARAVEL "A e B"
            Console.WriteLine("Digite o valor de b: ");
            b = int.Parse(Console.ReadLine());

            // PRODUTO SIMPLES MULTIPLICAÇÃO DOS DOIS VALORES INSERIDOS POR USUARIO.

            produto = a * b;
            Console.WriteLine("Resultado = " + produto);
        }
    }
}
