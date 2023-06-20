using Interfaces.Entities;
using Interfaces.Services;
using System.Globalization;
namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício - Exemplo sobre Interfaces
             Uma empresa de aluguer de carros cobra um valor por hora para alugueres até 12 horas. Porém, se a duração da utilização 
             ultrapassar 12 horas será cobrado um valor diário. Além do valor do aluguer , é acrescido no preçoo valor do imposto que é 20% 
             para valores até 100.00, ou 15% para valores acima de 100.00. Fazer um programa que lê os dados do aluguer do 
             carro (modelo do carro, instante inicial e final do aluguer), bem como o valor por hora e o valor diário de aluguer. 
             O programa deve então gerar a nota de pagamento(contendo valor do aluguer, valor do imposto e valor total do pagamento) e 
             informar os dados na consola. Veja os exemplos.
            */

            //Método sem interface:
            /*
            Console.WriteLine("------Enter rental data------");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(hour, day);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine();
            Console.WriteLine("------");
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
            */

            //Ao usar interface ITaxService, alteramos coisas no PortugalTaxService e no RentalService e no programa só alteramos uma coisa
            //no RentalService rentalService = new RentalService(hour, day, new PortugalTaxService());

            Console.WriteLine("------Enter rental data------");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(hour, day, new PortugalTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine();
            Console.WriteLine("------");
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);

        }
    }
}