using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1012
{
    class Area
    {
        public string Triangulo, Circulo, Trapezio, Quadrado, Retangulo;
        public double A, B, C, RS;

        public double CalculoArea(string a)
        {
            switch (CalculoArea(a))
            {
                case 1:
                    a = Triangulo;
                    Console.WriteLine("Triangulo: " + RS);
                    RS = A * C / 2;
                    break;
                case 2:
                    a = Circulo;
                    RS = C * C * 3.14;
                    Console.WriteLine("Circulo: " + RS);
                    break;
                        case 3:
                    a = Trapezio;
                    RS = A + B * C / 2;
                    Console.WriteLine("Trapezio" + RS);
                    break;
                case 4:
                    a = Quadrado;
                    RS = B * B;
                    Console.WriteLine("Trapezio: " + RS);
                    break;
                case 5:
                    RS = A * B;
                    a = Retangulo;
                    Console.WriteLine("Retangulo: " + RS);
                    break;
                default:
                    Console.WriteLine("Selecione uma area ser Calculada");
                    break;

            }
            return CalculoArea(a);

        }

    }
}
