using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int QuartoEscolhido { get; set; }

        public Quarto (string nome, string email, int quartoEscolhido) // Definição do construtor
        {
            Nome = nome;
            Email = email;
            QuartoEscolhido = quartoEscolhido;
        }

        public override string ToString()
        {
            return "Nome: " + Nome 
                + "\n" +
                "Email: " + Email
                + "\n" + 
                "Quarto:" + QuartoEscolhido
                + "\n";
        }
    }
}
