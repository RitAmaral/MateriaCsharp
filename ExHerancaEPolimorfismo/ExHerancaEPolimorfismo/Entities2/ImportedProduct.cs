using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHerancaEPolimorfismo.Entities2
{
    internal class ImportedProduct : Product
    {
        //Propriedades
        public double CustomsFee { get; set; }

        //Construtores
        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) :base(name, price)
        {
            CustomsFee = customsFee;
        }

        //Métodos
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string PriceTag() //não precisamos de fazer o método ToString
        {
            return Name + " $ " + TotalPrice().ToString("F2") + " (Customs fee: $ " + CustomsFee.ToString("F2") + ")";
        }
    }
}
