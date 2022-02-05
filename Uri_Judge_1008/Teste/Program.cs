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
            //valor pago por horas trabalhas, e calculo de salario
            string nm;
            int n, h;
            double ch, sal = 0.0;
            Console.WriteLine("Ola CONTRIBUINTE, Qual o Nome  Do Funcionario: ");
            nm = Console.ReadLine();
            Console.WriteLine("Qual Numero De: " + nm);
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas horas " + nm + " Trabalhou: ");
            h = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual Preço Atual da Hora Trabalhada: ");
            ch = double.Parse(Console.ReadLine());

            sal = h * ch; // hora trabalha x o custo da hora

            Console.WriteLine(nm + " Recebera um valor de: " + sal.ToString("F2"));
            Console.ReadLine();

        }
    }
}
