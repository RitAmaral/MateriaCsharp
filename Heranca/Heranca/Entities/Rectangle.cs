using Heranca.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    internal class Rectangle : Shape
    {
        //Propriedades
        public double Width { get; set; }
        public double Height { get; set; }

        //Construtores
        //public Rectangle() { }

        public Rectangle(Color color, double width, double height) : base(color) 
        {  
            Width = width; 
            Height = height; 
        }
        //Métodos
        public override double Area()
        {
            return Width * Height;
        }

    }
}
