using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Interfaces.Entities
{
    internal class Invoice
    {
        //Propriedades
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment // esta propriedade é calculada (é uma propriedade implementada)
        { 
            get { return BasicPayment + Tax; } //fazemos get para obter um valor; não há set. só vamos ter o valor obtido do cálculo.
        }

        //Construtores
        
        public Invoice() { }
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        

        //Métodos - definição da impressão de Invoice
        public override string ToString()
        {
            return "Basic Payment: " + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: " + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal Payment: " + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
