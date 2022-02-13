using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI2013
{
    class Program
    {
        static void Main(string[] args)
        {
            Maior a;
            a = new Maior();
            Console.WriteLine("Digite 3");
            a.A = int.Parse(Console.ReadLine());
            a.B= int.Parse(Console.ReadLine());
            a.C= int.Parse(Console.ReadLine());
            
            Console.WriteLine("Numeor maior " + a.NumeroMaior());
            Console.ReadLine();
        }
    }
}
