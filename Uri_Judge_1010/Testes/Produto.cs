using System;


namespace Testes
{
    class Produto
    {
        public string Nome;
        public int Quantidade;
        public double Valor;
        public double ValorPeca()
        {
         return Quantidade * Valor;
        }


    }
}
