using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHerancaEPolimorfismo.Entities
{
    internal class Employee
    {
        //Propriedades
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }


        //Construtores
        public Employee() { } //construtor padrão

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        //Secção de Métodos
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return
                Name + " - $ " + Payment();
        }
    }
}
