using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    internal class BusinessAccount : Account //business account (subclasse) é uma herança de account (superclasse)
    {
        //-------Propriedades
        //BusinessAccount herda as propriedades de Account, por isso não repetimos aqui
        public double LoanLimit { get; set; }

        //--------Construtores
        public BusinessAccount() { } //Construtor padrão

        //ir à classe Account e copiar o construtor para aqui (number, holder, balance) e acrescentar o loanlimit.
        public BusinessAccount(int number, string holder, double balance, double loanLimit) :base(number, holder, balance)
        {
            /*Number = number;
            Holder = holder; --- não é preciso colocar estes 3 argumentos (number, holder,balance), porque já estão dentro do base
            Balance = balance;*/
            LoanLimit = loanLimit;
        }
            
        //--------Secção dos Métodos
        //BA já extende os métodos base de Account que são: Withdraw e Deposit.
        public void Loan (double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

    }
}
