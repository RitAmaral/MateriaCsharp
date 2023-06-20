using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHerancaEPolimorfismo.Entities2
{
    internal class UsedProduct : Product
    {
        //Propriedades
        public DateTime ManufactureDate { get; set; }

        //Construtores
        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate) :base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        //Métodos
        public override string PriceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2") + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
        /*
        public override string ToString()
        {
            return
                ManufactureDate + PriceTag();
        }
        */
    }
}
