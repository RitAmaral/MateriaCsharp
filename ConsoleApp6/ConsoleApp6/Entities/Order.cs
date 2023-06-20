using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.Entities.Enum;

namespace ConsoleApp6.Entities
{
    internal class Order
    {
        //Propriedades
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; } //Propriedade do tipo OrderStatus chamado Status
        public Client Client { get; set; }
        public List<OrderItem> ListaItems { get; set; } = new List<OrderItem>(); //aparece no ex como 1 Order para muitos OrderItem, por isso criamos lista

        //Construtores
        public Order() { } //construtor padrão

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        //Secção de Métodos
        public void AddItem(OrderItem item) //passar pelo parâmetro OrderItem (como aparece no pdf do exercício)
        {
            ListaItems.Add(item);
        }

        public void RemoveItem(OrderItem item) 
        {  
            ListaItems.Remove(item); 
        }

        public double Total()
        {
            double soma = 0;
            foreach (OrderItem item in ListaItems)
            {
                soma += item.SubTotal();
            }
            return soma;
        }

        /*public override string ToString()
        {
            return 
                "Momento da encomenda: " + Moment.ToString("dd/MM/yyyy HH:mm:ss")
                + "\n"
                + "Status da encomenda: " + Status
                + "\n"
                + "Cliente: " + Client
                + "\n"
                + "Order itens: " + ListaItems
                + "\n"
                + "Preço total: " + Total().ToString("F2")
                ;
        }*/

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); //StringBuilder - classe que permite imprimir maiores quantidades de texto
            sb.AppendLine("Momento da encomenda: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status da encomenda: " + Status);
            sb.AppendLine("Cliente: " + Client);
            sb.AppendLine("Order itens: ");
            foreach (OrderItem item in ListaItems)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Preço Total: " + Total().ToString("F2"));
            return sb.ToString();
        }

    }
}
