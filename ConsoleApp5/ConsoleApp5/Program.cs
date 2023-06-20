using System.Collections;
using System.Collections.Generic; // em listas é preciso escrever: using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        { // em listas é preciso escrever logo no início: using System.Collections.Generic;
            /* 
        //Um método de declarar e instanciar:
        List<string> list; //declaração da lista
        list = new List<string>(); //instanciar a lista
        */
            /*
            //Outro método: Declaração e instanciação da Lista, inicializada a zero:
            List<string> list = new List<string>();

            //Outra lista:
            List<string> list2 = new List<string> { "Maria", "Carlos", "José", "Filipa" };

            //Add: adiciona no primeiro espaço livre, insert: adiciona no sítio que queremos (até pode substituir o que está lá)
            list2.Add("Rita");
            list2.Add("Rui");
            list2.Add("Carlos");
            list2.Add("Natália");

            //AddRange: fazer uma adição de vários elementos de uma vez só:
            list2.AddRange(new string[] { "Fábio", "Joana" });

            //O ciclo foreach vai percorrer todas as strings (neste caso demos o nome de nome) da list2:
            foreach (string nome in list2) 
            {
                //Console.WriteLine(nome);
                //ou usando a interpolação ($):
                Console.Write($"{nome}, ");
            }
            
            //Colocar os itens da list2 na list:
            list.AddRange(list2);
            foreach(string nome in list)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine();
            */
            //Outro exemplo de colocar uma lista na outra:
            /*
            List<string> listcarros = new List<string> { "Aston Martin" };
            List<string> carros = new List<string> { "Tesla", "Ferrari"};
            listcarros.AddRange(carros);
            foreach(string nomecarro in carros)
            {
                Console.WriteLine(nomecarro);
            }
            Console.WriteLine();
            foreach (string nomecarro in listcarros)
            {
                Console.WriteLine(nomecarro);
            }
            Console.WriteLine();

            //Função Count:
            Console.WriteLine("Quantos carros existem na lista?");
            Console.WriteLine(listcarros.Count()); //Output = 3
            Console.WriteLine();

            //Função Find:
            string x = listcarros.Find(list3 => list3.Contains("T"));
            Console.WriteLine(x); //Output = Tesla
            Console.WriteLine();

            string y = listcarros.Find(list3 => list3 == "Ferrari");
            Console.WriteLine(y); // Output = Ferrari
            Console.WriteLine();

            //Retrieve an item in a C# List at a specific position
            Console.WriteLine(listcarros[0]); // Output: Aston Martin

            //Função Capacity: número de elementos que a lista consegue conter.
            Console.WriteLine("Capacity: " + listcarros.Capacity); //Output: 4
            */
            /*
            //Função Insert:
            var list4 = new List<string>() { "Pássaro" };
            list4.Insert(0, "Sapo");

            var list5 = new List<string>() { "Cão" };
            list5.Insert(0, "Gato");
            list5.Insert(2, "Cobra");
            list5.Insert(2, "Águia"); // a cobra vai passar para a posição 3, não é eliminada quando a água vai para a posição 2

            //Resultados:
            Console.WriteLine("Lista 4: ");
            foreach (string a in list4)
            {
                Console.WriteLine(a); // Output: Sapo, Pássaro
            }
            Console.WriteLine("Lista 5: ");
            foreach (string a in list5)
            {
                Console.WriteLine(a); //Output: Gato, Cão, Águia, Cobra
            }
            */
            /*
            //Função Find Last ou lastItem:
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };

            var lastItem = numeros.Last();

            Console.WriteLine(lastItem); // Output é 5
            */
            /*
            //Função List.FindIndex:
            
            List<int> listanumeros = new List<int>() { 3, 5, 2, 7, 6 };
            int item = 5;

            int index = listanumeros.IndexOf(item);
            if (index != -1)
            {
                Console.WriteLine(String.Format("Elemento {0} é encontrado no index {1}", item, index)); //Output: Elemento 5 é encontrado no index 1
            }
            else
            {
                Console.WriteLine("Elemento não encontrado na lista fornecida.");
            }
            */

            /*
            // Função List.FindLastIndex:
            List<int> a = new List<int>() { 10, 20, 30, 40, 50, 10, 20, 30, 40, 50 };

            //print the list
            Console.WriteLine("Lista de elementos: ");
            foreach (int item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //Encontrar o último 20 da lista:
            int index = a.LastIndexOf(20);
            if (index != -1)
                Console.WriteLine("O último 20 é encontrado na posição: " + index); //Output: o último 20 é encontrado na posição 6
            else
                Console.WriteLine("20 não está na lista fornecida");
            */
            /*
            //Exemplo
            List<Carro> carros = new List<Carro>();
            
            Carro carro1 = new Carro { Name = "BMW", Matricula = "HA-51-45", Ano = 2018 };
            Carro carro2 = new Carro { Name = "Alfa Romeo", Matricula = "85-GF-KJ", Ano = 2022 };
            Carro carro3 = new Carro { Name = "Fiat500", Matricula = "78-LL-65", Ano = 1989 };

            carros.Add(carro1);
            carros.Add(carro2);
            carros.Add(carro3);

            foreach (Carro carro in carros) 
            {
                Console.WriteLine($" Carros: {carro.Name}, {carro.Matricula}, {carro.Ano}");
            }

            Console.WriteLine();
            //ou
            foreach (Carro carro in carros)
            {
                Console.WriteLine("Nome: " + carro.Name);
                Console.WriteLine("Matricula: " + carro.Matricula);
                Console.WriteLine("Ano: " + carro.Ano);
            }
            */

            //Exercício
            /*Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de N funcionários. 
            Não deve haver repetição de id. Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
            Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma mensagem e abortar a operação. 
            Ao final, mostrar a listagem atualizada dos funcionários, conforme exemplos. Nota: Aplicar a técnica de 
            encapsulamento para não permitir que o salário possaser mudado livremente. Um salário só pode ser aumentado 
            com base em umaoperação de aumento por percentagem dada.*/
            /*
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.WriteLine("Quantos funcionários vão ser registados? ");
            int n = int.Parse(Console.ReadLine());

            Funcionario funcionario1 = new Funcionario { ID = 333, Nome = "Maria Brown", SetSalario(3000.00) };
            Funcionario funcionario2 = new Funcionario { ID = 536, Nome = "Alex Grey", SetSalario(4000.00) };
            Funcionario funcionario3 = new Funcionario { ID = 772, Nome = "Bob Green", SetSalario(5000.00) };

            funcionarios.Add(funcionario1);
            funcionarios.Add(funcionario2);
            funcionarios.Add(funcionario3);

            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine($" Funcionarios: {funcionario.ID}, {funcionario.Nome}, {funcionario.GetSalario()}");
            }
            //resolução na aula c - listas
            */

            /*--------------Função If-else-------------------*/
            /*
            Console.WriteLine("What day is it today?");
            int y = int.Parse(Console.ReadLine());
            string day;

            if (y == 1)
            {
                day = "Sunday";
            }
            else if (y == 2) 
            {
                day = "Monday";
            }
            else if (y == 3)
            {
                day = "Tuesday";
            }
            else if (y == 4)
            {
                day = "Wednesday";
            }
            else if (y == 5)
            {
                day = "Thursday";
            }
            else if (y == 6)
            {
                day = "Friday";
            }
            else if (y == 7)
            {
                day = "Saturday";
            }
            else
            {
                day = "Invalid value";
            }

            Console.WriteLine("Today is: " + day);
            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine();
            */
            /*--------------------Função SWITCH-CASE------------------*/
            /*
            Console.WriteLine("Que dia da semana é hoje? ");
            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda";
                    break;
                case 3:
                    dia = "Terça";
                    break;
                case 4:
                    dia = "Quarta";
                    break;
                case 5:
                    dia = "Quinta";
                    break;
                case 6:
                    dia = "Sexta";
                    break;
                case 7:
                    dia = "Sábado";
                    break;
                default:
                    dia = "Dia inválido";
                    break;
            }
            
            Console.WriteLine("Hoje é: " + dia);
            */


            /*---------------------DATE TIME----------------------------*/
            DateTime d1 = DateTime.Now;
            Console.WriteLine("Date Time: " + d1); // aparece o dia e a hora
            Console.WriteLine("Date Time Ticks: " + d1.Ticks);
            Console.WriteLine();

            DateTime d2 = new DateTime(2023, 5, 12); //Imprime a data que passamos pelo parâmetro
            Console.WriteLine(d2); //Output = 12/05/2023 00:00:00
            Console.WriteLine();

            DateTime d3 = new DateTime(2023, 5, 12, 11, 49, 59);
            Console.WriteLine(d3); 
            Console.WriteLine();

            DateTime d4 = new DateTime(2023, 5, 12, 11, 49, 58, 275); //os 275 milisegundos não aparecem na consola.
            Console.WriteLine(d4);
            Console.WriteLine();

            DateTime d5 = DateTime.UtcNow; //imprime horário universal
            Console.WriteLine(d5);
            Console.WriteLine();

            DateTime d6 = DateTime.Today; // imprime a data, mas a hora fica a zeros
            Console.WriteLine(d6);
            Console.WriteLine();


            DateTime d7 = DateTime.Parse("2022-08-10");
            Console.WriteLine("DateTime d7: " + d7);
            Console.WriteLine();

            DateTime d8 = DateTime.Parse("2022-08-10 15:10:57"); //com hora incluída
            Console.WriteLine("DateTime d8: " + d8);
            Console.WriteLine();

            DateTime d9 = DateTime.Parse("12/05/2023 15:10:57"); //com hora incluída
            Console.WriteLine("DateTime d9: " + d9);
            Console.WriteLine();

            /*-----------------------------ParseExact-----------------------*/
            //Nota: quando usar Culture info, colocar em cima: using System.Globalization;)

            DateTime d10 = DateTime.ParseExact("2021-05-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine("DateTime d10: " + d10);
            Console.WriteLine();

            DateTime d11 = DateTime.ParseExact("12/05/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("DateTime d11: " + d11); 
            Console.WriteLine();

            /*-------------------Propriedades------------------*/

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
            Console.WriteLine("-----------------");
            Console.WriteLine();

            /*-----------Formatação (DateTime -> string)------------*/

            DateTime D = new DateTime(2001, 8, 15, 13, 45, 58);
            
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
            Console.WriteLine("-------------------");
            Console.WriteLine();

            /*----------------------*/

            DateTime x = new DateTime(2020, 04, 20, 13, 45, 30);

            //DateTime y = x.Add(TimeSpan);
            DateTime y1 = x.AddDays(2);
            DateTime y2 = x.AddHours(3);
            DateTime y3 = x.AddMilliseconds(2);
            DateTime y4 = x.AddMinutes(3);
            DateTime y5 = x.AddMonths(2);
            DateTime y6 = x.AddSeconds(3);
            DateTime y7 = x.AddTicks(2);
            DateTime y8 = x.AddYears(3);

            //DateTime y9 = x.Subtract(TimeSpan);

            Console.WriteLine("Adiciona dias: " + y1);
            Console.WriteLine("Adiciona horas: " + y2);
            Console.WriteLine("Adiciona milisegundos: " + y3);
            Console.WriteLine("Adiciona minutos: " + y4);
            Console.WriteLine("Adiciona meses: " + y5);
            Console.WriteLine("Adiciona segundos: " + y6);
            Console.WriteLine("Adiciona ticks: " + y7);
            Console.WriteLine("Adcionar anos: " + y8);

            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();

        }
    }
}