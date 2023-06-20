using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Listas
{
    internal class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double percentagem)
        {
            Salario += (Salario * percentagem) / 100;
        }

        public override string ToString()
        {
            return "\n"
                + "ID: " + ID
                + "\n"
                + "Nome: " + Nome
                + "\n"
                + "Salário: " + Salario.ToString("F2")
                + "\n"
                + "----------";
        }
    }
}
