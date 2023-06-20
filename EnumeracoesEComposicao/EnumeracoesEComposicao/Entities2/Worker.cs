using System;
using System.Collections.Generic; //sempre que aparecem lista, temos de ter este sistema
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumeracoesEComposicao.Entities2.Enums2;

namespace EnumeracoesEComposicao.Entities2
{
    internal class Worker
    {
        //Propriedades
        public string Name { get; set; } //atributo ou propriedade
        public WorkerLevel Level { get; set; } //atributo ou propriedade (este vem do enum WorkerLevel)
        public double BaseSalary { get; set; } //atributo ou propriedade
        public Department Department { get; set; } //composição: cada Worker tem 1 e 1 só Department
        public List <HourContract> Contracts { get; set; } = new List<HourContract>(); //Propriedade do tipo lista, lista chamada Contracts

        //Construtores
        public Worker() { } //construtor padrão

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) //não devemos pôr listas nos construtores
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Secção de Métodos
        public void AddContract(HourContract contract) //sempre que tivermos uma lista, temos de ter 2 métodos: add e remove
        {
            Contracts.Add(contract); //este contract chega aqui pelo parâmetro contract em cima.
        }
        public void RemoveContract(HourContract contract) //void = não retorna nada
        {
            Contracts.Remove(contract);
        }
        public double Income(int month, int year) //aqui não é void, porque vai retornar um valor
        {
            double soma = BaseSalary; //inicia no valor base, não em zero
            foreach (HourContract contract in Contracts) //"para cada contract do tipo HourContract na lista Constracts"
            {
                if (month == contract.Date.Month && year == contract.Date.Year)
                {
                    soma += contract.TotalValue();
                }
            }
            return soma;
        }
    }
}
