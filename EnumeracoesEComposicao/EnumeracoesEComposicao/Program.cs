using EnumeracoesEComposicao.Entities.Enums;
using EnumeracoesEComposicao.Entities;
using System.Runtime.ConstrainedExecution;
using EnumeracoesEComposicao.Entities2.Enums2;
using EnumeracoesEComposicao.Entities2;
using System.Diagnostics.Contracts;

namespace EnumeracoesEComposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*--------------------Propriedades--------------------*/
            
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();

            /*------------------Formatação (DateTime -> string)-------------------------*/

            DateTime D = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            string s1 = D.ToLongDateString();
            string s2 = D.ToLongTimeString();
            string s3 = D.ToShortDateString();
            string s4 = D.ToShortTimeString();
            string s5 = D.ToString();
            string s6 = D.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = D.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();

            /*------------------Operações com Datetime-------------------------*/

            DateTime x1 = new DateTime(2001, 8, 15, 13, 45, 58);
            Console.WriteLine(x1);

            DateTime y1 = x1.Add(TimeSpan.Zero);
            Console.WriteLine(y1);
            DateTime y2 = x1.AddDays(2);
            Console.WriteLine("Adiciona dias: " + y2);
            DateTime y3 = x1.AddHours(2);
            Console.WriteLine("Adiciona horas: " + y3);
            DateTime y4 = x1.AddMilliseconds(2);
            Console.WriteLine("Adiciona milisegundos: " + y4);
            DateTime y5 = x1.AddMinutes(2);
            Console.WriteLine("Adiciona minutos: " + y5);
            DateTime y6 = x1.AddMonths(2);
            Console.WriteLine("Adiciona meses: " + y6);
            DateTime y7 = x1.AddSeconds(2);
            Console.WriteLine("Adiciona segundos: " + y7);
            DateTime y8 = x1.AddTicks(2);
            Console.WriteLine("Adiciona Ticks: " + y8);
            DateTime y9 = x1.AddYears(2);
            Console.WriteLine("Adiciona anos: " + y9);

            DateTime y10 = x1.Subtract(TimeSpan.Zero);
            Console.WriteLine(y10);

            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();

            /*-------------------Enumerações------------------------*/

            //Criar classes: Order e OrderStatus

            Order order = new Order
            {
                Id = 12,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };
            Console.WriteLine(order);

            Console.WriteLine();

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt); //Output = PendingPayment

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os); //Output = Delivered

            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();

            /*-------------------Exercício----------------*/

            /*Ler os dados de um trabalhador com N contratos(N fornecido pelo utilizador).Depois, no 
            final, solicitar ao utilizador que indique um mês e mostrar qual foi o salário 
            do funcionário nesse mês.*/

            Console.WriteLine("Nome do departamento: ");
            string nameDept = Console.ReadLine();

            Console.WriteLine("Dados do trabalhador: ");
            Console.WriteLine("Nome do trabalhador: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nível do trabalhador (Junior/Mid_Level/Senior: ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine()); //workerLevel = variável auxiliar
            Console.WriteLine("Salário base do trabalhador: ");
            double baseSalary = double.Parse(Console.ReadLine());


            Department department1 = new Department(nameDept);
            Worker worker1 = new Worker(name, workerLevel, baseSalary, department1);

            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();

            Console.WriteLine("Quantos contratos tem este trabalhador? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Dados do contrato #" + i + ": "); //ou: ($"Dados do contrato #{i}:")
                Console.WriteLine("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Duração (horas): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours); 
                worker1.AddContract(contract);//Adicionamos o novo contrato, através do método AddContract, à nossa lista contract
            }

            Console.WriteLine();

            Console.WriteLine("Escreva o mês e o ano (MM/YYYY) para calcular o salário (income): ");
            string respData = Console.ReadLine();
            int month = int.Parse(respData.Substring(0, 2)); //função substring = corta o texto a partir do ponto que queremos (0) até onde queremos (2)
            int year = int.Parse(respData.Substring(3)); //só colocamos 3, porque só queremos a partir do ponto 3 até ao final
            Console.WriteLine();

            Console.WriteLine("Nome do trabalhador: " + worker1.Name);
            Console.WriteLine("Nome do departamento: " + worker1.Department.NameDept);
            Console.WriteLine("Salário base: " + worker1.BaseSalary.ToString("F2"));
            Console.WriteLine("Salário total em " + respData + " (salário base + contratos): " + worker1.Income(month, year).ToString("F2"));
        }
    }
}