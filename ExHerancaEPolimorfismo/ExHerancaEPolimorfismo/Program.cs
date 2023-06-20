using ExHerancaEPolimorfismo.Entities;
using ExHerancaEPolimorfismo.Entities2;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace ExHerancaEPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*----------------------------------Exercício 1-----------------------------*/
            /*Uma empresa possui funcionários próprios e subcontratados. Para cada funcionário, deseja-se registar nome, horas trabalhadas e 
            valor por hora. Funcionários subcontratados possuem ainda uma despesa adicional. O pagamento dos funcionários corresponde 
            ao valor/hora multiplicado pelas horas trabalhadas, sendo que os funcionários subcontratados ainda recebem um bónus 
            correspondente a 110% de sua despesa adicional.
            Fazer um programa para ler os dados de N funcionários (N fornecido pelo utilizador) e armazená-los numa lista. Depois de ler 
            todos os dados, mostrar nome e pagamento de cada funcionário na mesma ordem em que foram inseridos. Construa
            o programa conforme exemplo na próxima página.*/
            /*
            Console.WriteLine("Enter the number of employees: ");
            int N = int.Parse(Console.ReadLine());

            List<Employee> listas = new List<Employee>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine());

                if (outsourced == 'n' || outsourced == 'N')
                {
                    Console.WriteLine("--------------");
                    listas.Add(new Employee(name, hours, valueperhour));
                }
                else
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    Console.WriteLine("--------------");

                    listas.Add(new OutsourcedEmployee(name, hours, valueperhour, additionalCharge));
                }
            }
            Console.WriteLine("--------------");
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee obj in listas)
            {
                Console.WriteLine(obj);
            }
            */

            /*----------------------------------Exercício 2-----------------------------*/
            /*Fazer um programa para ler os dados de N produtos (N fornecido pelo utilizador). No final, mostrar a etiqueta de preço 
            de cada produto na mesma ordem em que foram inseridos. Todo produto possui nome e preço. Produtos importados possuem 
            uma taxa de alfândega, e produtos usados possuem data de fabricação. Estes dados específicos devem ser acrescentados 
            na etiqueta de preço conforme exemplo (próxima página). Para produtos importados, a taxa e alfândega deve ser 
            acrescentada ao preço final do produto.*/

            Console.WriteLine("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());

            List<Product> lista = new List<Product>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (resp == 'i' || resp == 'I')
                {
                    Console.Write("Customs Fee: ");
                    double customsfee = double.Parse(Console.ReadLine());
                    lista.Add(new ImportedProduct(name, price, customsfee));
                }
                else if (resp == 'u' || resp == 'U')
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacturedate = DateTime.Parse(Console.ReadLine());
                    lista.Add(new UsedProduct(name, price, manufacturedate));
                }
                else
                { 
                    Console.WriteLine();
                    lista.Add(new Product(name, price));
                }
            }
            Console.WriteLine("-------------");
            Console.WriteLine("Price Tags: ");
            foreach(Product product in lista)
            {
                Console.WriteLine(product.PriceTag());
            }

        }
    }
}