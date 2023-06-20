using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHerancaEPolimorfismo.Entities
{
    internal class OutsourcedEmployee : Employee //OutsourcedEmployee herda de Employee
    {
        //Propriedades, sendo que as do employee são herdades mas não aparecem aqui
        public double AdditionalCharge { get; set; }

        //Construtores
        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        //Secção de Métodos
        public override double Payment()
        {
            //return (Hours * ValuePerHour) + (AdditionalCharge * 1.1);
            //ou:
            return base.Payment() + (AdditionalCharge * 1.1);
        }
    }
}
