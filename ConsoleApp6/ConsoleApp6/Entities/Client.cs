using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.Entities.Enum;

namespace ConsoleApp6.Entities
{
    internal class Client
    {
        //Propriedades
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        //Construtores
        public Client() { }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return 
                Name + BirthDate.ToString(" (dd/MM/yyyy)") +" - " //colocar máscara dd/MM/yyyy
                + Email;
        }
    }
}
