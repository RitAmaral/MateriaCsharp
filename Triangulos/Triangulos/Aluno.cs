using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        
        public bool Aprovado()
        {
            if (NotaFinal()>=60)
            { 
                return true; 
            }
            else
            { 
                return false;
            }
        }
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
        public override string ToString()
        {
        return "Nome: " + Nome
               + "\n"
               + "Primeira nota: " + Nota1
               + "\n"
               + "Segunda nota " + Nota2
               + "\n"
               + "Terceira nota: " + Nota3
               + "\n"
               + "Nota final: " + NotaFinal();

        }
    }
}
