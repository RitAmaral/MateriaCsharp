using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities
{
    internal class CarRental
    {
        //Propriedades
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        //Construtores
        public CarRental() { }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null; //quando alugamos um carro, o invoice/fatura começa em zero (e não podemos instanciar o invoice a "zeros").
                            //Por isso colocamos aqui nulo, mas também podemos tirar, não dá erro.
        }

    }
}
