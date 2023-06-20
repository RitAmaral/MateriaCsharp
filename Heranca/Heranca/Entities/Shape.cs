using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heranca.Entities.Enums;

namespace Heranca.Entities
{
    internal abstract class Shape
    {
        //Propriedades
        public Color Color { get; set; }

        //Construtores
        //public Shape() { }
        public Shape(Color color)
        {
            Color = color;
        }

        //Métodos - shape apenas tem um método que é Area(), este método é abstrato / está escrito a itálico no exercício)
        //como é abstrato, apenas apresentamos a assinatura dele
        public abstract double Area();


    }
}
