using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;

namespace ConsoleApp2Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Declaracao e Instanciacao da lista
            List<string> list = new List<string>(); // inicializacao a zero
            List<string> list2 = new List<string> { "Maria", "Carlos", "José", "Filipa", "Maria" };
            List<string> list3 = new List<string> { "Olivia", "Rambo", "Inês" };

            /*-----------------------ADD-------------------------*/

            list2.Add("Cecilia");
            foreach (string nome in list2)
            {
                Console.Write($"{nome}, ");
            }
            Console.WriteLine();
            Console.WriteLine();
            /*-----------------------INSERT-------------------------*/

            list2.Insert(2, "Sara");
            foreach (string nome in list2)
            {
                Console.Write($"{nome}, ");

            }
            Console.WriteLine();
            Console.WriteLine();

            /*-----------------------ADDRANGE-------------------------*/

            list2.AddRange(new string[] { "Diogo", "Sofia", "Carolina" });
            foreach (string nome in list2)
            {
                Console.Write($"{nome}, ");
            }
            Console.WriteLine();
            Console.WriteLine();

            /*-----------------------ADDRANGE-varios elementos-------------------------*/

            list2.AddRange(list3);
            foreach (string nome in list2)
            {
                Console.Write($"{nome}, ");
            }
            Console.WriteLine();
            Console.WriteLine();

            /*-----------------------SORT-------------------------*/
            //Organiza por ordem alfabética
            list2.Sort();
            foreach (string nome in list2)
            {
                Console.Write($"{nome}, ");
            }
            Console.WriteLine();
            Console.WriteLine();

            /*-----------------------REVERSE-------------------------*/
            //Organiza por ordem contrária da ordem alfabética
            list2.Reverse();
            foreach (string nome in list2)
            {
                Console.Write($"{nome}, ");
            }
            Console.WriteLine();
            Console.WriteLine();

            /*-----------------------COUNT-------------------------*/
            int count = list2.Count;
            list2.Count();
            Console.WriteLine($"A lista contém {count} elementos."); //Output = 13 elementos

            Console.WriteLine();

            /*-----------------------LIST.FIND-------------------------*/
            //buscar o primeiro elemento da lista list2 que comece com a letra 'C'.
            //a list2 está neste momento organizada pela ordem inversa da ordem alfabética
            string resultado = list2.Find(nome => nome[0] == 'C'); //Output = Cecilia
            Console.WriteLine(resultado);

            Console.WriteLine();

            /*-----------------------LIST.FINDLAST-------------------------*/
            //retorna o último nome que corresponde ao predicado especificado, em vez do primeiro.

            string resultLast = list2.FindLast(nome => nome == "Carlos");
            Console.WriteLine(resultLast);

            Console.WriteLine();

            /*-----------------------LIST.FINDLASTINDEX-------------------------*/
            //retorna o índice do último elemento que corresponde ao predicado especificado.

            int resultIndex = list2.FindLastIndex(nome => nome == "Cecilia"); //Output = 10
            Console.WriteLine(resultIndex);

            Console.WriteLine();

            /*-----------------------LIST.FINDALL-------------------------*/
            // retorna uma nova lista contendo todos os elementos que atendem à condição
            // especificada na expressão lambda
            List<string> nomesComLetraA = list2.FindAll(nome => nome == "Maria");

            Console.WriteLine("O nome escolhido repete quantas vezes aparecer repetido: ");
            foreach (string nome in nomesComLetraA)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine();
            /*-----------------------REMOVE-------------------------*/

            list2.Remove("Sara");
            foreach (string nome in list2)
            {
                Console.Write($"{nome}, ");

            }
            Console.WriteLine();
            Console.WriteLine();

            /*-----------------------REMOVEALL-------------------------*/
            // Remove todas as ocorrências de "Maria" na lista
            list2.RemoveAll(nome => nome == "Maria");
            foreach (string nome in list2)
            {
                Console.Write($"{nome}, ");

            }
            Console.WriteLine();
            Console.WriteLine();

            /*-----------------------REMOVEAT-------------------------*/
            //Remove o elemento da lista que está na posição 2(índice 1)
            list2.RemoveAt(1);
            foreach (string nome in list2)
            {
                Console.Write($"{nome}, ");

            }
            Console.WriteLine();
            Console.WriteLine();

            /*-----------------------REMOVERANGE-------------------------*/
            // Remove os elementos da lista que estão nas posições de 0 a 1 (índices 0 e 1)
            list2.RemoveRange(0, 2); //se aqui meter 3, tira 3 nomes
            foreach (string nome in list2)
            {
                Console.Write($"{nome}, ");

            }
            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();

            /*---------------------------EXERCÍCIO-----------------------*/
            /*Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de N funcionários. 
            Não deve haver repetição de id. Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
            Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma mensagem e abortar a operação. 
            Ao final, mostrar a listagem atualizada dos funcionários, conforme exemplos. Nota: Aplicar a técnica de 
            encapsulamento para não permitir que o salário possaser mudado livremente. Um salário só pode ser aumentado 
            com base em umaoperação de aumento por percentagem dada.*/

            Console.WriteLine("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());
            List<Funcionario> listas = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Funcionário  #{i}:"); //ou: Console.WriteLine("Funcionário # " + i + ": ");
                Console.WriteLine("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                listas.Add(new Funcionario(id, nome, salario));
            }
            Console.WriteLine();
            Console.WriteLine("Insira o ID do funcionário que irá receber aumento: ");
            int funcionarioID = int.Parse(Console.ReadLine());

            Funcionario temp = listas.Find(x => x.ID == funcionarioID);
            if (temp != null)
            {
                Console.WriteLine("Insira a percentagem do aumento: ");
                double aumento = double.Parse(Console.ReadLine());
                temp.AumentarSalario(aumento);
            }
            else
            {
                Console.WriteLine("Esse ID não existe");
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("Lista atualizada dos funcionários: ");
            foreach (Funcionario obj in listas)
            {
                Console.WriteLine(obj);
            }

        }
    }
}