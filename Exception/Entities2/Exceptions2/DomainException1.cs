using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExException.Entities2.Exceptions2
{
    internal class DomainException1 : ApplicationException
    {
        public DomainException1(string message) : base(message) { } //esta message já vem do ApplicationException (herda de lá)
    }
}
