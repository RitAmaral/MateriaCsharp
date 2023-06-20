using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Caixa
    {
        public double lado;

        public Caixa () // o construtor tem sempre o nome da classe, e neste caso está vazio ().
        {
            lado = 10; // atributo lado, que cada lado inicia em 10.
        }

        public Caixa (double outroValor) // o construtor não está vazio (double outroValor)
        {
            lado = outroValor;
        }

        public double CalculaVolume() 
        { return lado * lado * lado; }
    }
}
