using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    internal class ConversorDeMoeda
    {
        public static double Imposto = 6.0;

        public static double DolarEuro(double quantia, double cotacao) 
        {
            double total = quantia * cotacao;
            return total + total * Imposto / 100.0; 
        }
    }
}
