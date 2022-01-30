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
            // SOMA DE DOIS VALORES
            int a, b, x = 0;
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor de a: " + a);

            b = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor de b : " + b);

            x = a + b;
            Console.WriteLine("Resultado de X : " + x);
        }
    }
}
