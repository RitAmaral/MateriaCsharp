using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.Entities;

namespace ConsoleApp6.Entities.Enum
{
    internal enum OrderStatus : int //mudar de class para enum
    {//OrderStatus vai herdar da classe int. int é uma classe.
        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
