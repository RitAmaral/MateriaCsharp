using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    internal abstract class Account //quando uma classe-mãe é abstrata ela não pode ser instanciada - vantagem: reuso de código e de proteção
    {
        //----------Secção de Propriedades

        public int Number {  get; set; }
        public string Holder { get; set; }
        public double Balance { get; protected set; } //se colocar private set a business account não consegue alterar o Balance, logo usar protected

        //----------Construtores

        public Account() //contrutor padrão
        {
            
        }

        public Account(int number, string holder, double balance) //construtor com argumentos
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //---------------Secção de Métodos
        //Método para levantamento
        public virtual void Withdraw(double amount) //Para que um método comum (não abstrato) possa ser sobreposto, deve ser incluído nele o prefixo "virtual"
        {
            Balance -= amount + 5.0;
        }
        //Método para depósito
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        

    }
}
