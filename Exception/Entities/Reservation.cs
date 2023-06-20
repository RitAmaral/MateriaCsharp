using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExException.Entities.Exceptions;

namespace ExException.Entities
{
    internal class Reservation
    {   //Propriedades
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        //Construtores

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut < checkIn)
            {
                throw new DomainException("Atenção, a data de check-out tem que ser superior à data de check-in.");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        //Métodos
        public int Duration()
        {

            if (CheckOut <= CheckIn)
            {
                throw new DomainException("Datas inválidas.");
            }
            else
            {
                TimeSpan duration = CheckOut.Subtract(CheckIn); //isto vem em double
                return (int)duration.TotalDays; //logo fazemos uma conversão (casting) para receber dados em inteiro.
            }

        }
        public void UpdateDates (DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now) 
            {
                throw new DomainException("Não pode reservar para datas inferiores ao dia de hoje!");
            }
            else if (checkOut <= CheckIn)
            {
                throw new DomainException("Tens que ficar aqui pelo menos uma noite!");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room " + RoomNumber + ", check-in: " + CheckIn.ToString("dd/MM/yyyy") 
                + ", check-out: " + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " nights.";
        }


    }
}
