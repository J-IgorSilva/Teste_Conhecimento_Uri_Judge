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
            //ler numero de um funcionario, as horas trabalhadas
            //qual loja é o vendedor
            // qual salario
            //quanto vendeu
            //valor pago por horas trabalhas, e calculo de salario
            // 15% de bonos por salario
            //
            string JOSE, LUIZ, RICARDO, MATHEUS;
            string[] venderor; // vetor para os funcionarios
            venderor = new string[4]; // 4 vendedores
            double fxsal, ttvendas;
            int lj = 0;
            Console.WriteLine("Bom dia, Qual o Numero da sua loja: LJ01,loja2 ");

            lj = int.Parse(Console.ReadLine());

            switch (lj)
            {
                case 1:

                    Console.WriteLine("Loja 01 - Avenida Antonio F N° 235");
                    break;
                case 2:
                    Console.WriteLine("Loja 02 - Avenida Sr Dumas dias s/n");
                    break;
                case 3:
                    Console.WriteLine("Loja 03 - Avenida Demias Silas");
                    break;
                case 4:
                    Console.WriteLine("Loja 04 - Rua Senhor Melo Rego n°13");
                    break;

            }
            Console.ReadLine();



        }
    }
}
