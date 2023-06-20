using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumeracoesEComposicao.Entities.Enums;

namespace EnumeracoesEComposicao.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return "\n"
                + "Id: " + Id
                + "\n"
                + "Moment: " + Moment
                + "\n"
                + "Status: " + Status;
        }
    }
}
