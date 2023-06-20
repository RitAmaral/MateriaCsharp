using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heranca.Entities.Enums;

namespace Heranca.Entities
{
    internal class Circle : Shape
    {
        //Propriedades
        public double Radius { get; set; }

        //Construtores
        //public Circle() { }
        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        //Métodos
        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }



    }
}
