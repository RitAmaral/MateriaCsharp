using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumeracoesEComposicao.Entities;

namespace EnumeracoesEComposicao.Entities.Enums
{
    internal enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing  = 1,
        Shipped = 2,
        Delivered = 3
    }
}
