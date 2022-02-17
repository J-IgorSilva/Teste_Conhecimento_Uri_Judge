using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARRO
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c;
            c = new Carro();

            Console.WriteLine("Distancia do carro 1 :");
            c.Car1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Distancia do Carro 2 :");
            c.Car2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos minutos de diferenca entre o Primeio e Segundo Carro: ");
            c.hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a diferança em kilometros do primeiro para o segundo");
            c.km = int.Parse(Console.ReadLine());
            Console.WriteLine(" a diferenca é " + c.Kilometro());
            Console.ReadLine();
        }
    }
}
