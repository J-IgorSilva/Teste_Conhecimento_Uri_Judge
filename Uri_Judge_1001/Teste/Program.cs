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
            Console.WriteLine("Digite 2 Valores: ");
            int x, a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            x = a + b;
            
            Console.WriteLine($"A Soma dos Valores: {a} , {b}" + " é Igual a "+ x);
        }
    }
}
