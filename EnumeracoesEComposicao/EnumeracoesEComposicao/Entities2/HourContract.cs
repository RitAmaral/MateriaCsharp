using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumeracoesEComposicao.Entities2.Enums2;

namespace EnumeracoesEComposicao.Entities2
{
    internal class HourContract
    {
        //Propriedades da classe HourContract
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set;}

        //Construtores
        public HourContract() { } //Construtor Padrão - é criado vazio
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            //Vamos atribuir valores, que sao os que ele recebe do programa, ou seja que o utilizador escreveu no terminal
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public HourContract(double valuePerHour, int hours)
        {
            ValuePerHour = valuePerHour;
            Hours = Hours;
        }

       
        //Secção de Métodos
        public double TotalValue() 
        { 
            return ValuePerHour * Hours;
        }

    }
}
