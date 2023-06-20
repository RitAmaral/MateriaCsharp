using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /*Criamos como se fosse uma classe, mas depois tiramos internal class e colocamos struct*/
    struct Point
    {
        public double x, y;

        public override string ToString()
        {
            return "(" + x + ", " + y + ")"; // output será um ponto cartesiano: (x, y)
        }
    }
}
