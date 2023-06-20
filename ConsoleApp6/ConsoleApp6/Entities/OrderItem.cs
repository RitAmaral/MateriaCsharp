using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.Entities.Enum;

namespace ConsoleApp6.Entities
{
    internal class OrderItem
    {
        //Propriedades
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; } //este product vem da classe Product
        //não é uma propriedade original de Order.

        //Construtores
        public OrderItem() { } //construtor padrão (vazio)

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }


        //Secção dos Métodos
        public double SubTotal() 
        { 
            return Quantity * Price; 
        }

        public override string ToString()
        {
            return 
                "Nome do Produto: " + Product.Name 
                + ", quantidade: " + Quantity + ", "
                + ", preço: " + Price.ToString("F2")
                + ", subtotal: " + SubTotal().ToString("F2");
        }
    }
}
