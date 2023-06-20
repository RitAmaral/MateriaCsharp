using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Pessoa
    {
        string Nome;
        int Id;
        int Idade;
        double Salario;

        public Pessoa() 
        { }
        public Pessoa(int id) 
        {
            Id = id;
        }
        public Pessoa(string nome, int id, double salario)
        {
            Nome = nome;
            Id = id;
            Salario = salario;
        }

        public override string ToString()
        {
            return "Nome: " + Nome
                   + "\n" 
                   + "Id: "
                   + Id.ToString()
                   + "\n"
                   + "Idade: "
                   + Idade
                   + "\n"
                   + "Salario: "
                   + Salario.ToString("F2"); ;
        }
    }




}
