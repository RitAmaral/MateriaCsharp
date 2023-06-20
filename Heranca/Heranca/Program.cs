using Heranca.Entities;
using Heranca.Entities.Enums;
using System.Collections.Generic;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*---------------Aula sobre Herança e Polimorfismo: 23/05/2023--------------*/
            /*
            BusinessAccount businessAccount = new BusinessAccount(1001,"Rui",500,1000);

            Console.WriteLine(businessAccount.Balance); //Output = 500
            */
            //businessAccount.Balance = 200; //isto não é possível porque a propriedade Balance da classe Account está protegida (protected set).


            /*---------Upcasting-------------*/
            /*
            //Vamos instanciar uma conta acc do tipo account:
            Account acc = new Account(1002, "José", 500);
            //Vamos instanciar uma conta ba do tipo business account:
            BusinessAccount ba = new BusinessAccount(1006, "SWDevelopers", 0, 50000);

            //Upcasting
            Account acc1 = ba; //Conversão de BA numa account: esta acc1 vai receber ba (deixou de ser empresa(businessaccount) e agora é apenas uma account)
            //como fizemos a conversão, já não aparece o método loan da bussiness account, se fizermos cw(acc1.Loan());
            Console.WriteLine(acc1.Balance); //Output = 0

            Account acc2 = new BusinessAccount(10, "Mar@s", 4000, 10000); //acc2 recebe uma businessaccount, mas é uma account!
            Account acc3 = new SavingsAccount(520, "António", 15000, 0.02); //acc3 recebe uma savingsaccount, mas é uma account!

            Console.WriteLine(acc3.Balance); //Output = 15000
            //Console.WriteLine(acc3.InteresRate); //Isto não é possível porque já não é uma savingsaccount, é uma account.
            */

            /*---------Downcasting-------------*/
            /*
            BusinessAccount acc4 = (BusinessAccount)acc2;
            Console.WriteLine(acc4.LoanLimit); //output = 10000; a acc4 passou para uma BusinessAccount, com os dados da acc2.

            //Podemos colocar isto de duas formas, a anterior ou:
            BusinessAccount acc5 = acc4 as BusinessAccount;
            Console.WriteLine(acc5.LoanLimit); //Output = 10000;

            acc4.Loan(100);
            */
            /*-------------Sobreposição ou sobrescrita-----------------*/
            /*
            Account acc6 = new Account(1010, "Ana", 500);
            Account acc7 = new SavingsAccount(1010, "Joana", 1000, 0.02);

            acc6.Withdraw(10);
            Console.WriteLine(acc6.Balance); //Output=485 (tiramos 10, mais taxa de 5 euros)

            acc7.Withdraw(10);
            Console.WriteLine(acc7.Balance); //Output = 990 (na savings account não tem mais taxa de 5 euros); nota: usar o base, agora o output é 983.
            */

            /*----------------------------Polimorfismo------------------------*/
            /*Em Programação Orientada a Objetos, polimorfismo é um recurso que permite que variáveis de um mesmo tipo
            mais genérico possam apontar para objetos de tipos específicos diferentes, tendo assim comportamentos
            diferentes conforme cada tipo específico.*/
            /*
            Account acc8 = new Account(1010, "Ana", 500);
            Account acc9 = new SavingsAccount(1010, "Joana", 500, 0.01);

            acc6.Withdraw(10);
            Console.WriteLine(acc8.Balance); 

            acc7.Withdraw(10);
            Console.WriteLine(acc9.Balance);
            */
            /*----------------------------Classes Abstratas----26/05/2023--------------------*/
            //acrescentamos abstract na classe Account
            /*
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(2000, "Maria", 500, 0.02));
            list.Add(new BusinessAccount(1001, "António", 500, 800));
            list.Add(new SavingsAccount(5001, "José", 500, 0.02));
            list.Add(new BusinessAccount(2001, "Ana", 500, 1000));

            double sum = 0;
            foreach (Account account in list)
            {
                sum += account.Balance;
            }
            Console.WriteLine("Saldo Total: " + sum.ToString("F2")); //somou os saldos todos, output = 2000.

            foreach (Account account in list)
            {
                account.Withdraw(10.0);
            }
            foreach (Account account in list)
            {
                Console.WriteLine("Saldo Atualizado: " + account.Number + ", " + account.Balance.ToString("F2"));
            }
            */
            /*----------------Exercício1 sobre Classes e métodos abstratos------------------*/
            /*Fazer um programa para ler os dados de N figuras (N fornecido pelo utilizador), e depois mostrar as áreas 
            destas figuras na mesma ordem em que foram inseridas.*/
            /*
            List<Shape> list1 = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= N; i++) 
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or circle (r/c): ");
                char resp = char.Parse(Console.ReadLine());
                if (resp == 'r' || resp == 'R')
                {
                    Console.Write("Color of the rectangle (Black/Blue/Red): ");
                    Color color1 = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Heigth: ");
                    double heigth = double.Parse(Console.ReadLine());
                    list1.Add(new Rectangle(color1, width, heigth));
                }
                else 
                {
                    Console.WriteLine("Color of the circle (Black / Blue / Red): ");
                    Color color2 = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list1.Add(new Circle(color2, radius));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shape in list1)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
            */

            /*----------------Exercício2 sobre Classes e métodos abstratos------------------*/

            List<TaxPayer> list2 = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Tax Payer #{i} data: ");
                Console.Write("Individual or Company (i/c)? ");
                char resp2 = char.Parse(Console.ReadLine());
                if (resp2 == 'I' || resp2 == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualinc = double.Parse(Console.ReadLine());
                    Console.Write("Health expenditures: ");
                    double healthexp = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    list2.Add(new Individual(name, anualinc, healthexp));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualinc = double.Parse(Console.ReadLine());
                    Console.Write("Number of employees: ");
                    int numberemp = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    list2.Add(new Company(name, anualinc, numberemp));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer obj in list2)
            {
                Console.WriteLine(obj.Tax().ToString("F2"));
            }
            Console.WriteLine();
            double sum1 = 0;
            foreach (TaxPayer obj in list2)
            {
                sum1 += obj.Tax();
            }
            Console.WriteLine("TOTAL TAXES: " + sum1.ToString("F2"));
            Console.WriteLine("------------------------");

        }
    }
}
