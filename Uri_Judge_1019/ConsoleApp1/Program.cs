using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            // a ideia por enquanto foi de apenas, dividir para obter minutos, mas devo usar
            // o timespan para deixar mais limpo e pratico.
            Console.WriteLine("Digite o tempo em segudos: ");
            double tempo,segundo = 0.0;
            segundo = double.Parse(Console.ReadLine());
            tempo = segundo / 60;
            Console.WriteLine("A Quantidade em minutos é: " + tempo);
            Console.WriteLine();
        }
    }
}
