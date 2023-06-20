using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ContaBancaria
    {
        public int NumConta;
        public string Nome;
        public double ValorDepInicial;
        public double Deposito;
        public double Levantamento;
        public double taxa = 5.00;
        public double SaldoInicial = 0;

        public double PrimeiroSaldo() { return SaldoInicial + ValorDepInicial; }
        public double Levantamentos() { return Levantamento + taxa; }
        public double SaldoAtual() 
        {
            if (Levantamento >= 1)
            {
                return PrimeiroSaldo() + Deposito - Levantamentos();
            }
            else
            {
                return PrimeiroSaldo() + Deposito;
            }
        }
        public ContaBancaria() { }
        public override string ToString()
        {
            return
                "\n"
                + "Número de Conta: " + NumConta
                + "\n"
                + "Nome: " + Nome
                + "\n"
                + "Saldo Inicial: "+ SaldoInicial
                + "\n"
                + "Primeiro Saldo: " + PrimeiroSaldo()
                + "\n"
                + "Saldo Atual: " + SaldoAtual();
        }
    }
}
