using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.Entities.Enum;

namespace ConsoleApp6.Entities
{
    internal class Product
    {
        //Propriedades
        public string Name { get; set; }
        public double Price { get; set; }

        //Construtores
        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        /*public override string ToString()
        {
            return 
                "Produtos encomendados: " + Name + ", "
                + "\n"
                + Price + " euros, ";
        }*/
    }
}
