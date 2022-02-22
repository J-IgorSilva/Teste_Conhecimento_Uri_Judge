using System;
namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int n100, a, n50, b, n20, c, n10, n5, e, n2, f;
            double valor;
            Console.WriteLine("Insira o valor: ");
            valor = double.Parse(Console.ReadLine());
            a = (int)valor / 100;
            n100 = a;
            b = ((int) valor % 100);
            n50 = b / 50;
            c = ((int)valor %100) /50;
            n20 = c % 20;
            e = c / 10;
            n10= c % 10;
            f = e / 5;
            n5 = f;
            n2 = f / 2;
            // poderia inserir um vetor para as notas  como forech
            Console.WriteLine(n100); 
            Console.WriteLine(n50);
            Console.WriteLine(n20);
            Console.WriteLine(n10);
            Console.WriteLine(n5); 
            Console.WriteLine(n2);
        }
    }
}
