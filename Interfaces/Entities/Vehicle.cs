using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities
{
    internal class Vehicle
    {
        //Propriedade
        public string Model { get; set; }

        //Construtor
        public Vehicle() { }
        public Vehicle(string model)
        {
            Model = model;
        }

        

    }
}
