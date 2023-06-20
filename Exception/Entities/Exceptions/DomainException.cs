using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExException.Entities.Exceptions
{
    internal class DomainException : ApplicationException //herda da ApplicationException, que já herda de Exceptions do C#
    {
        //Construtor
        public DomainException(string message) :base(message) { } //esta message já vem do ApplicationException (herda de lá)
    }
}
