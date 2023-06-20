using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        private double _salario;
        public double GetSalario()
        {
            return _salario;
        }
        
    }
}
