using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    internal abstract class TaxPayer
    {
        //Propriedades
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        //Construtores
        public TaxPayer(string name, double anualIncome) 
        { 
            Name = name;
            AnualIncome = anualIncome;
        }

        //Secção de Métodos
        public abstract double Tax();
    }
}
