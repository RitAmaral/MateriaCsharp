using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Entities
{
    internal class Comment
    {
        //Propriedades
        public string Text { get; set; }

        //Construtores
        public Comment() { } //construtor padrão

        public Comment(string text)
        {
            Text = text;
        }

    }
}
