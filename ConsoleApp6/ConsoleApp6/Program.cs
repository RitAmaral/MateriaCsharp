using ConsoleApp6.Entities.Enum;
using ConsoleApp6.Entities;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aula 16/05/2023

            /*------------------------------Exercício---------------*/
            /* Ler os dados de um pedido com N itens (N fornecido pelo utilizador). Depois, mostrar um sumário do pedido
            conforme exemplo (próxima página). Nota: o instante do pedido deve ser o instante do sistema: DateTime.Now */

            Console.WriteLine("Escreva os dados do cliente: ");
            Console.WriteLine("Nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Data de Nascimento(DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Escreva os dados da encomenda: ");
            Console.WriteLine("Status (Pending_Payment/Processing/Shipped/Delivered: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine("Quantos itens vão estar nesta encomenda? ");
            int N = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate); //criar novo objeto com 3 parâmetros(?)
            Order order = new Order(DateTime.Now, status, client);

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Dados do item #{i}: ");
                Console.WriteLine("Nome do produto: ");
                string nameP = Console.ReadLine();
                Console.WriteLine("Preço do produto: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(nameP, price);
                Console.WriteLine("Quantidade: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
                Console.WriteLine("-----------------");
            }
            

            Console.WriteLine("Sumário da encomenda: ");
            Console.WriteLine();
            Console.WriteLine(order);
            //Console.WriteLine(cliente1);
            //Console.WriteLine(produto1);
            //Console.WriteLine(orderitem1);

        }
    }
}