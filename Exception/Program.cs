using ExException.Entities;
using ExException.Entities.Exceptions;
using ExException.Entities2;
using ExException.Entities2.Exceptions2;
using System.Transactions;

namespace ExException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            try 
            { //tenta fazer isto que está aqui em baixo
                Console.Write("Escreve o primeiro número: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Escreve o segundo número: ");
                int n2 = int.Parse(Console.ReadLine());
            
                int resultado = n1 / n2;
                Console.WriteLine("O resultado é: " + resultado);
            } // se não conseguires, capta este erro:
            catch (DivideByZeroException) //é uma excepção do sistema
            {
                Console.WriteLine("É impossível dividir por zero!"); //se n1 = 10 e n2 = 0, o output vai ser: "É impossível ..."
            }
            */

            //Outra forma de escrever:
            /*
            try
            { 
                Console.Write("Escreve o primeiro número: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Escreve o segundo número: ");
                int n2 = int.Parse(Console.ReadLine());

                int resultado = n1 / n2;
                Console.WriteLine("O resultado é: " + resultado);
            } 
            catch (DivideByZeroException e) 
            {
                Console.WriteLine(e.Message); //É uma mensagem do sistema; output= Attempted to divide by zero.
            } 
            */

            //-------------------------------------Exercício - Criar exceções personalizadas -------------------------------------

            /*
            Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, data de entrada e data de saída) e 
            mostrar os dados da reserva, inclusive sua duração em dias. Em seguida, ler novas datas de entrada e saída, atualizar 
            a reserva, e mostrar novamente a reserva com os dados atualizados. O programa não deve aceitar dados inválidos para 
            a reserva, conforme as seguintes regras: 
            - Alterações de reserva só podem ocorrer para datas futuras. 
            - A data de saída deve ser maior que a data de entrada
            */
            //Exercício feito sem Exception (sem criar a pasta e a classe DomainException)
            /*
            Console.Write("Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in Date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out Date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Não pode reservar um quarto com uma data inferior ao check-in.");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();

                Console.WriteLine("Enter data to update reservation: ");
                Console.Write("Check-in Date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out Date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());
                Console.WriteLine();

                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now) 
                {
                    Console.WriteLine("Erro! Não pode reservar para datas inferiores ao dia de hoje!");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Erro! Tens que ficar aqui pelo menos uma noite!");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
            */

            //Exercício feito com Exception (criar a pasta e a classe DomainException, e acrescentar na classe Reservation os ifs)
            /*
            try
            {
                Console.Write("Room Number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in Date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out Date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();

                Console.WriteLine("Enter data to update reservation: ");
                Console.Write("Check-in Date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out Date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());
                Console.WriteLine();

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

            }
            catch (DomainException ex)
            {
                Console.WriteLine("Erro na reserva: " + ex.Message);
            }
            catch (FormatException ex) //FormatException é criada pelo C#
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            */

            //Exercício
            /*
            Fazer um programa para ler os dados de uma conta bancária e depois realizar um levantamento nesta conta bancária e 
            mostrar o novo saldo. Um levantamento não pode ocorrer ou se não houver saldo na conta, ou se o valor do levantamento 
            for superior ao limite de levantamento da conta. Implemente a conta bancária conforme projeto abaixo:
            */
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double initialbalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit: ");
                double withdrawlimit = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Account account = new Account(number, holder, initialbalance, withdrawlimit);

                Console.Write("Enter amount for Withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());
                account.Withdraw(withdraw);
                Console.WriteLine();

                Console.WriteLine(account);
            }
            catch (DomainException1 e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

        }
    }
}