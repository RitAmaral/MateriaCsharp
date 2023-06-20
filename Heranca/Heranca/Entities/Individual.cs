using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    internal class Individual : TaxPayer
    {
        
        //Propriedades
        public double HealthExpenditures { get; set; }

        //Construtores
        public Individual(string name, double anualIncome, double healthExpenditures) : base (name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        //Métodos
        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else 
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
        }


    }
}
