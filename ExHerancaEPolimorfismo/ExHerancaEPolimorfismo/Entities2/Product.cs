using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHerancaEPolimorfismo.Entities2
{
    internal class Product
    {
        //Propriedades da superclasse Product
        public string Name { get; set; }
        public double Price { get; set; }

        //Construtores
        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //Secção de Métodos
        public virtual string PriceTag() //não precisamos de fazer o método ToString
        {
            return Name + " $ " + Price.ToString("F2");
        }
    }
}
