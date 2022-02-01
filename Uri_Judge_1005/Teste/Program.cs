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
            double a, b, media;
            Console.WriteLine("Qual a nota AP1 de João: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a nota AP2 de João: ");
            b = double.Parse(Console.ReadLine());
            media = a + b / 2;
            Console.WriteLine("A Media de João : " + media);
            Console.ReadLine();
        }
    }
}
