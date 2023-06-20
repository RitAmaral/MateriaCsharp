using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    internal class Func
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem) / 100;
        }
        public override string ToString()
        {
            return "Nome: " + Nome
                   + "\n"
                   + "Salário Bruto " + SalarioBruto
                   + "\n"
                   + "Imposto " + Imposto
                   + "\n" // faz quebra de linha
                   + "Salário Líquido: " + SalarioLiquido();
        }
    }
}
