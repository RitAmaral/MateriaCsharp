using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumeracoesEComposicao.Entities2.Enums2;

namespace EnumeracoesEComposicao.Entities2
{
    internal class Department //Criamos classe departamento que depois vai ser chamada na classe Worker
    {
        //Propriedades de Department:
        public string NameDept { get; set; }

        //Construtores
        public Department(string nameDept) //este construtor recebe por parâmetro um argumento "nameDep"
        {
            NameDept = nameDept; 
        }

        public Department() { } //Outro construtor criado, vazio
    }
}
