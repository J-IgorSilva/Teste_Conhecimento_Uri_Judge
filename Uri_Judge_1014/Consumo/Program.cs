using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c;
            c = new Carro();
            Console.WriteLine("Digite Quantos Km foram Percorridos:___");
            c.Kilometro = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite Quantos Litros Foram Usados:___");
            c.Combustivel = double.Parse(Console.ReadLine());
            double gasto = 0.0;

            Console.WriteLine("O Gasto total Foi de " + c.DCarro(gasto).ToString("F3)"+ "Km/l"));
            Console.ReadKey();

        }
    }
}
