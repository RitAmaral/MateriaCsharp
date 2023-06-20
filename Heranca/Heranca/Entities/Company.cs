using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    internal class Company : TaxPayer
    {
        //Propriedades
        public int NumberOfEmployees { get; set; }

        //Construtores
        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        //Métodos
        public override double Tax()
        {
            if (NumberOfEmployees < 10)
            {
                return AnualIncome * 0.16;
            }
            else 
            {
                return AnualIncome * 0.14;
            }

        }
    }
}
