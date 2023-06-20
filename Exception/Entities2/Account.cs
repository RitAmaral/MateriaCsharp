using ExException.Entities2.Exceptions2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExException.Entities2
{
    internal class Account
    {
        //Propriedades
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        //Construtores
        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        //Métodos
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException1("The amount exceeds draw limit.");
            }
            else if (amount > Balance)
            {
                throw new DomainException1("The amount exceeds your balance.");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return "New Balance: " + Balance;
        }
    }
}
