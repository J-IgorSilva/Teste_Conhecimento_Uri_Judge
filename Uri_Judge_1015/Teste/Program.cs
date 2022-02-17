using System;


namespace Teste
{
    class Program : ProgramBase
    {
        static void Main(string[] args)
        {
            //Ler quatro valores, aos eixos x e y 
            // calcule a distância entre eles, mostrando quatro casas decimais
            ProgramBase p = new ProgramBase();

            var value1=0.0; var value2 = 0.0; var value3 = 0.0; var value4=0.0; double raiz;

            Console.WriteLine("Insira 4 Valores Para medir as Distancias entres os pontos");

            value2 = p.Leitura(value1);
            value1 = p.Leitura(value2);
            value3 = p.Leitura(value3);
            value4 = p.Leitura(value4);

            raiz = Math.Sqrt(value1 - value2) + Math.Sqrt(value3 - value4);

            Console.WriteLine(raiz.ToString("N4"));


        }
    }
}
