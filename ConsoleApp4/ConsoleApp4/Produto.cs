﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        /*ou:
         public Produto (string nome, double preco) 
            Nome = nome;
            Preco = preco;
        */
    }
}