using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1012
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Insira as Areas:");
            Area figuras, a;
            figuras = new Area();
            figuras.A = double.Parse(Console.ReadLine());
            figuras.B = double.Parse(Console.ReadLine());
            figuras.C = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Escolha Qual Figura Deseja Calcular a Area");
            Console.WriteLine("Triangulo");
            Console.WriteLine("Retangulo");
            Console.WriteLine("Circulo");
            Console.WriteLine("Trapezio");
            Console.WriteLine("Quadrado");


            string b;
            b = Console.ReadLine();
            switch (b = figuras.Triangulo) 
            { 
                case 1: 
                    
            }
        }
    }
}
