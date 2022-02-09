using System;

namespace Testes
{
    class Program : Produto
    {
        static void Main(string[] args)
        {

            Produto P, Vt;
            Vt = new Produto();
            P = new Produto();
            Console.WriteLine("Insira o nome do produto: ");
            P.Nome= (Console.ReadLine());
            Console.WriteLine("Qual a quantida desejada: ");
            P.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("qual valor de cada peça: ");
            P.Valor = double.Parse(Console.ReadLine());
   

            Console.WriteLine("valor total: " + P.ValorPeca());


        }
    }
}
+