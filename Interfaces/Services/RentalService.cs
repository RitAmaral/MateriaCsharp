using Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interfaces.Services
{
    internal class RentalService
    {
        //Propriedades
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //public PortugalTaxService PortugalTaxService = new PortugalTaxService(); //estamos a instanciar um new PortugalTaxService dentro do RentalService
                                                                          //estamos num serviço de alugar que tem uma composição com o país de Portugal.
        //Agora com interface ITaxService:
        public ITaxService TaxService;

        //Construtores
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            TaxService = taxService; //temos também de chamar a interface dentro do construtor
        }
        public void ProcessInvoice(CarRental carRental)
        {
            //Cálculo da duração do aluguer do carro
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start); //subtract é subtrair, posso apenas colocar o sinal menos: -.

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
                //Math.Ceiling faz o arredondamento para cima do valor da hora.
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            //double tax = PortugalTaxService.Tax(basicPayment);
            double tax = TaxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}

