using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    internal class Triangulo
    {
        public double A; // são os lados/atributos do triângulo (A, B, C)
        public double B;
        public double C;

        public double Area () 
        { 
            double p = (A + B + C) / 2;
            return Math.Sqrt(p *(p - A) * (p - B) * (p - C)); 
        }
    }
}
