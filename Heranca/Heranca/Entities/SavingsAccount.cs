using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    //Suponha que quer evitar que sejam criadas subclasses de SavingsAccount, colocamos sealed:
    internal sealed class SavingsAccount : Account //savings account (subclasse) é uma herança de account (superclasse)
    {
        //-------Propriedades
        public double InterestRate { get; set; }

        //-------Construtores
        public SavingsAccount() //construtor padrão
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) :base (number, holder, balance)
        {
            InterestRate = interestRate;
        }

        //-------Secção de Métodos
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) //Ao sobrescrever um método, devemos incluir nele o prefixo "override"
        { //Suponha que não quer que o método Withdraw de SavingsAccount seja sobreposto novamente, colocamos sealed. objetivo: segurança
            base.Withdraw(amount); //a base chama implementações da classe mãe (account)
            Balance -= 2.0; //queremos ainda retirar 2 euros, do saldo
        }
    }
}
